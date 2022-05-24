using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class BMWModelCars : Cars
    {
        public string GetCarModel()
        {
            return "BMW 320D";
        }

        public int GetCarPrice()
        {
            return 900000;
        }

        public string GetColor()
        {
            return "White";
        }
    }
}
