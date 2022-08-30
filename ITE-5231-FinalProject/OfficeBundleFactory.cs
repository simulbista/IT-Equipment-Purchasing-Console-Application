using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class OfficeBundleFactory : ProductAbstractFactory
    {
        public override ILaptop GetLaptop()
        {
            return new OfficeLaptop();
        }

        public override IMonitor GetMonitor()
        {
            return new OfficeMonitor();
        }
    }
}
