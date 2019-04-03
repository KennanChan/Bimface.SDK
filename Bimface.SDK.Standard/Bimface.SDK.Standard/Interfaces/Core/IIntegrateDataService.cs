using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IIntegrateDataService
    {
        Task<string> DeleteFileElementProperties(DeleteFileElementPropertiesParameter parameter);
    }
}