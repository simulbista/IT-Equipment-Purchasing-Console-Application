using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class OfficeLaptop : ILaptop
    {
        private string laptopModel = "HP-Elitebook";
        private double price = 1200;

        public string GetModel()
        {
            Console.WriteLine("The office laptop model is " + laptopModel);
            return laptopModel;
        }

        public double GetPrice()
        {
            Console.WriteLine("The office laptop price is " + price);
            return price;
        }
    }
}
