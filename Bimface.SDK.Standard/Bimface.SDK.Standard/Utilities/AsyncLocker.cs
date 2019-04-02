#region

using System;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Utilities
{
    /// <summary>
    ///     A locker to ensure that only one thread can access the resource at one time using <see cref="SemaphoreSlim"/>
    /// </summary>
    public class AsyncLocker
    {
        #region Constructors

        public AsyncLocker()
        {
            Semaphore       = new SemaphoreSlim(1, 1);
            CurrentUnlocker = Task.FromResult(new Unlocker(this));
        }

        #endregion

        #region Properties

        private Task<Unlocker> CurrentUnlocker { get; }
        private SemaphoreSlim  Semaphore       { get; }

        #endregion

        #region Others

        /// <summary>
        ///     Create an <see cref="Unlocker"/> to release the <see cref="AsyncLocker"/>
        /// </summary>
        /// <returns>The instance of <see cref="Unlocker"/> used to release <see cref="AsyncLocker"/></returns>
        public Task<Unlocker> LockAsync()
        {
            var waitTask = Semaphore.WaitAsync();
            return waitTask.IsCompleted
                       ? CurrentUnlocker
                       : waitTask.ContinueWith((_, state) => new Unlocker((AsyncLocker) state),
                           this, CancellationToken.None,
                           TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        #endregion

        /// <summary>
        ///     Automatically release the lock on disposed
        /// </summary>
        public struct Unlocker : IDisposable
        {
            private AsyncLocker Locker { get; }

            internal Unlocker(AsyncLocker locker)
            {
                Locker = locker;
            }

            public void Dispose()
            {
                Locker?.Semaphore.Release();
            }
        }
    }
}