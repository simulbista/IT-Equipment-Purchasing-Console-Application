using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class GamingMonitor : IMonitor
    {
        private string monitorModel = "ASUS-TUFF-VG27VQ";
        private double price = 300;
        public string GetModel()
        {
            Console.WriteLine("The gaming monitor model is " + monitorModel);
            return monitorModel;
        }

        public double GetPrice()
        {
            Console.WriteLine("The gaming monitor price is " + price);
            return price;
        }
    }
}
