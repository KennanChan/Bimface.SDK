using Bimface.SDK.Entities.Http;
using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IMiddleware
    {
        Task<bool> Handle(HttpRequest request);
    }
}
