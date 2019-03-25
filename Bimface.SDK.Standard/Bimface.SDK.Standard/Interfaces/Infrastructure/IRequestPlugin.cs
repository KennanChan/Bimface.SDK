using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IRequestPlugin
    {
        Task<bool> Handle(HttpRequest request);
    }
}