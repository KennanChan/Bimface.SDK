using Bimface.SDK.Entities.Http;
using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IRequestPlugin
    {
        Task<bool> Handle(HttpRequest request);
    }
}
