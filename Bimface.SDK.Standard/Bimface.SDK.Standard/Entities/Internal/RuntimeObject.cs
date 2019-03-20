using Bimface.SDK.Attributes;
using System.ComponentModel.Design;

namespace Bimface.SDK.Entities.Internal
{
    internal abstract class RuntimeObject
    {
        [Inject] protected IServiceContainer Container { get; set; }
    }
}
