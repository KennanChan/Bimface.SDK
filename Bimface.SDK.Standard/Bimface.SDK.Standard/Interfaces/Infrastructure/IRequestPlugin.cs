#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IRequestPlugin
    {
        #region Others

        Task<bool> Handle(HttpRequest request);
        void PreBuild();

        #endregion
    }
}