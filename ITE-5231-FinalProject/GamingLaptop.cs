using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class GamingLaptop : ILaptop
    {
        private string laptopModel = "ASUS-Zephyrus-G2";
        private double price = 2000;
        public string GetModel()
        {
            Console.WriteLine("The gaming laptop model is " + laptopModel);
            return laptopModel;
        }

        public double GetPrice()
        {
            Console.WriteLine("The gaming laptop price is " + price);
            return price;
        }
    }
}
