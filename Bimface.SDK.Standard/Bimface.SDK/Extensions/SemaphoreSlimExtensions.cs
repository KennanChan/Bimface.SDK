using System;
using System.Threading;
using System.Threading.Tasks;

namespace Bimface.SDK.Extensions
{
    public static class SemaphoreSlimExtensions
    {
        public static Task AsyncWait(this SemaphoreSlim semaphore)
        {
#if NET40
            var tcs = new TaskCompletionSource<object>();
            ThreadPool.QueueUserWorkItem(state =>
            {
                try
                {
                    semaphore.Wait();
                    tcs.SetResult(null);
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
            });
            return tcs.Task;
#else
            return semaphore.WaitAsync();
#endif
        }
    }
}