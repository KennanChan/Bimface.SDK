#region

using System.ComponentModel.Design;
using Bimface.SDK.Attributes;

#endregion

namespace Bimface.SDK.Entities.Internal
{
    internal abstract class RuntimeObject
    {
        [Inject]
        protected IServiceContainer Container { get; set; }
    }
}