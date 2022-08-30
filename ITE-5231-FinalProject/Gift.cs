using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class Gift
    {
        //common field
        private GiftModel model;

        //unique field
        double warrantyInYears;


        public Gift(GiftModel gm, double wiy)
        {
            this.model = gm;
            this.warrantyInYears = wiy;
        }

        public void DisplayGift()
        {
            //generating a random no. to choose from the array of gifts in the giftmodel class
            Random rand = new Random();
            int randomGiftNo = rand.Next(0, model.gifts.Length);

            Console.WriteLine("You have received {0} year(s) of warranty on your product along with free {1}.", warrantyInYears, model.gifts[randomGiftNo]);
            Console.WriteLine();
        }
    }
}
