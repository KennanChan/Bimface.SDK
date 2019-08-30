#region

using System.Threading;
using System.Threading.Tasks;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Utilities
{
    /// <summary>
    ///     A locker to ensure that only one thread can access the resource at one time using <see cref="SemaphoreSlim" />
    /// </summary>
    public class AsyncLocker
    {
        #region Constructors

        public AsyncLocker()
        {
            Semaphore = new SemaphoreSlim(1, 1);
        }

        #endregion

        #region Properties

        private SemaphoreSlim Semaphore { get; }

        #endregion

        #region Others

        /// <summary>
        ///     Create an <see cref="Unlocker" /> to release the <see cref="AsyncLocker" />
        /// </summary>
        /// <returns>The instance of <see cref="Unlocker" /> used to release <see cref="AsyncLocker" /></returns>
        public Task<Unlocker> LockAsync()
        {
            var waitTask = Semaphore.AsyncWait();
            return waitTask.IsCompleted
                       ? TaskBuilder.FromResult(new Unlocker(this))
                       : waitTask.ContinueWith(task => new Unlocker(this),
                           CancellationToken.None,
                           TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        internal void Release()
        {
            //Release the lock to give access to another thread
            //Actually this call will make the semaphore complete the next waiting task
            Semaphore.Release();
        }

        #endregion
    }
}