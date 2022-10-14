using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_And_Contravariance
{
    internal class Derived: Base
    {
        public void DoMore() => Console.WriteLine($"Do more from {this.GetType().Name}");
    }
}
