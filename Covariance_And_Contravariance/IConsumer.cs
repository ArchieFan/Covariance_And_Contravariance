using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_And_Contravariance
{
    // Contravariant
    internal interface IConsumer<in T>
    {
        void Cosume(T obj);
    }
}
