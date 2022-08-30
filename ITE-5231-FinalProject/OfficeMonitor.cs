using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_5231_FinalProject
{
    internal class OfficeMonitor : IMonitor
    {
        private string monitorModel = "DELL-SE2422H";
        private double price = 150;
        public string GetModel()
        {
            Console.WriteLine("The office monitor model is " + monitorModel);
            return monitorModel;
        }

        public double GetPrice()
        {
            Console.WriteLine("The office monitor price is " + price);
            return price;
        }
    }
}
