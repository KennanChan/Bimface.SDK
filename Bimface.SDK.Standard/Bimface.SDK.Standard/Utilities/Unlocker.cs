#region

using System;

#endregion

namespace Bimface.SDK.Utilities
{
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
            Locker?.Release();
        }
    }
}