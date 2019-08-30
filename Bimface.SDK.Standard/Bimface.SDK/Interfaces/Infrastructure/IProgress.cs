using System;
using System.Collections.Generic;
using System.Text;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IProgress<T>
    {
        void Report(T progress);
    }
}
