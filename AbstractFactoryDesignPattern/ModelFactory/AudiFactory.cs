using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern.ModelFactory
{
    /// <summary>
    /// AudiFactory,BMWFactory , CarFactory sınıfının CreateCarProduct yöntemini uygular.
    /// bir nesne oluşturmak için bir interface veya abstract class tanımlamamız gerekiyor. 
    /// Örneğimizde, soyut bir sınıftır, yani CarFactory sınıfıdır. 
    /// Tanımın ikinci kısmı, alt sınıfların hangi sınıfı somutlaştıracağına karar vermesine izin verdiğini söylüyor.
    /// Örneğimizde alt sınıflar  BMWFactory ve AudiFactory'dir. Dolayısıyla bu alt sınıflar, örneğin Honda, BMW ve Ferrary gibi hangi sınıfın oluşturulacağına karar verecektir.
    /// </summary>
    public class AudiFactory : CarFactory
    {
        protected override Cars CreateCarProduct()
        {
            Cars _model = new AudiModelCars();
            return _model;
        }
    }
}
