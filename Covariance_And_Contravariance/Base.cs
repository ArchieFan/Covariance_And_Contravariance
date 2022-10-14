using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_And_Contravariance
{
    internal class Base
    {
        public void DoSomething() => Console.WriteLine($"Do from {this.GetType()}");
    }
}
