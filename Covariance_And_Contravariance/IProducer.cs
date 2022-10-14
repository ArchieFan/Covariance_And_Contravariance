using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_And_Contravariance
{
    // Convariant
    internal interface IProducer<out T> 
    {
        T Produce();
    }
}
