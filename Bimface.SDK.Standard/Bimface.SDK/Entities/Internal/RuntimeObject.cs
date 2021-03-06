﻿#region

using System.ComponentModel.Design;
using Bimface.SDK.Attributes;

#endregion

namespace Bimface.SDK.Entities.Internal
{
    internal abstract class RuntimeObject
    {
        #region Properties

        [Inject]
        internal IServiceContainer Container { get; set; }

        #endregion
    }
}