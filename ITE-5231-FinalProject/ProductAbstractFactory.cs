using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal abstract class ProductAbstractFactory
    {
        internal static ProductAbstractFactory GetProductFactory(string type)
        {
            if (type.Equals("gaming")) return new GamingBundleFactory();
            else return new OfficeBundleFactory();
        }

        internal static void GetGifts(string type)
        {
            GiftModel giftModel = GiftModel.getGifts();

            if (type.Equals("gaming"))
            {
                Gift g1 = new Gift(giftModel, 3);
                g1.DisplayGift();
            }
            else
            {
                Gift g1 = new Gift(giftModel, 1);
                g1.DisplayGift();
            }
        }

        public abstract ILaptop GetLaptop();
        public abstract IMonitor GetMonitor();
    }
}
