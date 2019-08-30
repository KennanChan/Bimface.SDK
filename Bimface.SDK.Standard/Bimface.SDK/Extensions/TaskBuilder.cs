#region

using System;
using System.Threading;
using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class TaskBuilder
    {
        #region Others

        public static Task<T> Run<T>(Func<T> handler)
        {
#if NET40
            return Task<T>.Factory.StartNew(handler);
#else
            return Task.Run(handler);
#endif
        }

        public static Task Run(Action handler)
        {
#if NET40
            return Task.Factory.StartNew(handler);
#else
            return Task.Run(handler);
#endif
        }

        public static Task<T> Run<T>(Func<Task<T>> handler)
        {
#if NET40
            var tcs = new TaskCompletionSource<T>();
            ThreadPool.QueueUserWorkItem(async state =>
            {
                try
                {
                    var task = handler();
                    tcs.SetResult(await task);
                }
                catch (Exception ex)
                {
                    tcs.SetException(ex);
                }
            });
            return tcs.Task;
#else
            return Task.Run(handler);
#endif
        }

        public static Task<T> FromResult<T>(T result)
        {
#if NET40
            var tcs = new TaskCompletionSource<T>();
            tcs.SetResult(result);
            return tcs.Task;
#else
            return Task.FromResult(result);
#endif
        }

        #endregion
    }
}