using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class GamingBundleFactory : ProductAbstractFactory
    {
        public override ILaptop GetLaptop()
        {
            return new GamingLaptop();
        }

        public override IMonitor GetMonitor()
        {
            return new GamingMonitor();
        }
    }
}
