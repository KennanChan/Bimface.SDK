using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Bimface.SDK.Utilities
{
    internal class AsyncLock
    {
        private AsyncSemaphore Semaphore { get; }
        private Task<Guard> CurrentGuard { get; }

        public AsyncLock()
        {
            Semaphore = new AsyncSemaphore(1);
            CurrentGuard = Task.FromResult(new Guard(this));
        }

        public Task<Guard> LockAsync()
        {
            var wait = Semaphore.WaitAsync();
            return wait.IsCompleted
                       ? CurrentGuard
                       : wait.ContinueWith((_, state) => new Guard((AsyncLock)state),
                           this, CancellationToken.None,
                           TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
        }

        public struct Guard : IDisposable
        {
            private AsyncLock ToRelease { get; }

            internal Guard(AsyncLock toRelease)
            {
                ToRelease = toRelease;
            }

            public void Dispose()
            {
                ToRelease?.Semaphore.Release();
            }
        }

        private class AsyncSemaphore
        {
            private readonly Queue<TaskCompletionSource<bool>> _waiters = new Queue<TaskCompletionSource<bool>>();
            private int _currentCount;

            public AsyncSemaphore(int initialCount)
            {
                if (initialCount < 0) throw new ArgumentOutOfRangeException(nameof(initialCount));
                _currentCount = initialCount;
            }

            public Task WaitAsync()
            {
                lock (_waiters)
                {
                    if (_currentCount > 0)
                    {
                        --_currentCount;
                        return Task.CompletedTask;
                    }
                    else
                    {
                        var waiter = new TaskCompletionSource<bool>();
                        _waiters.Enqueue(waiter);
                        return waiter.Task;
                    }
                }
            }

            public void Release()
            {
                TaskCompletionSource<bool> toRelease = null;
                lock (_waiters)
                {
                    if (_waiters.Count > 0)
                        toRelease = _waiters.Dequeue();
                    else
                        ++_currentCount;
                }

                toRelease?.SetResult(true);
            }
        }
    }
}