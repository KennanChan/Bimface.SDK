#region

using System;
using Bimface.SDK.Entities.Core.Responses;

#endregion

namespace Bimface.SDK.Test.Context
{
    public class BimfaceFileContext : IDisposable
    {
        public FileEntity SingleModelFile { get; set; }

        #region Interface Implementations

        public async void Dispose()
        {

        }

        #endregion
    }
}