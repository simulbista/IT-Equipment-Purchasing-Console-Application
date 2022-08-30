using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class GiftModel
    {
        public string[] gifts = { "MicrosoftO365 subscription", "mouse", "keyboard", "laptop-bag", "Amazon Gift Card", "Bluetooth Headphones", "Power Bank" };

        //unique instance of the class - singleton design pattern
        private static readonly GiftModel UniqueInstance = new GiftModel();

        //method tor return the unique instance of the class
        public static GiftModel getGifts()
        {
            return UniqueInstance;
        }

        //making the constructor private so that the class cannot be instantiated (for singleton)
        private GiftModel() { }
    }
}
