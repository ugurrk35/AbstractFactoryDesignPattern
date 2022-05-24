using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class AudiModelCars : Cars
    {
        public string GetCarModel()
        {
            return "Audi A3";
        }

        public int GetCarPrice()
        {
            return 780000;
        }

        public string GetColor()
        {
            return "Red";
        }
    }
}
