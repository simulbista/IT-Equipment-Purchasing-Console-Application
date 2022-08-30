using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class ApplicationFacade
    {
        internal void GetBundle(string choice)
        {
            ProductAbstractFactory.GetProductFactory(choice).GetMonitor().GetModel();
            ProductAbstractFactory.GetProductFactory(choice).GetMonitor().GetPrice();

            ProductAbstractFactory.GetProductFactory(choice).GetLaptop().GetModel();
            ProductAbstractFactory.GetProductFactory(choice).GetLaptop().GetPrice();

            ProductAbstractFactory.GetGifts(choice);
        }
    }
}
