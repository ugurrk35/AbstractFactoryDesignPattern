using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class BMWFactory : CarFactory
    {
        protected override Cars CreateCarProduct()
        {
            Cars _model = new BMWModelCars();
            return _model;
        }
    }
}
