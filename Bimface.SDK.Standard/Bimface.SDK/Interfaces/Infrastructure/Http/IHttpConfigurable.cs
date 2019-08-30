#region

using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpConfigurable
    {
        #region Others

        Task Configure();

        #endregion
    }
}