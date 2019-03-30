using System;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IRequestPlugin : IDisposable
    {
        Task<bool> Handle(HttpRequest request);
        void Prebuild();
    }
}