using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    /// <summary>
    /// Tanım gereği, nesneyi oluşturmak için soyut bir sınıf veya arayüz oluşturmamız gerekiyor. 
    /// Öyleyse, herkese açık bir yöntemle fabrika sınıfımız olacak soyut bir sınıf oluşturalım. 
    /// Bu yöntem, ürünün örneğini döndürecek olan fabrika yönteminden başka bir şey değildir.
    /// Bu nedenle, CarFactory.cs adlı bir sınıf dosyası oluşturuyoruz
    /// </summary>
    public abstract class CarFactory
    {
        protected abstract Cars CreateCarProduct();
        /// <summary>
        /// soyut sınıfı, tek bir soyut yöntemle, yani CreateCarProduct() ve bir somut yöntemle, 
        /// yani CarDetails() ile oluşturduk. CarDetails() yöntemi, ürün örneğini oluşturacak ve 
        /// bu örneği döndürecek olan alt sınıfın CreateCarProduct() yöntemini dahili olarak çağırır.
        /// </summary>
        public Cars CarDetails()

        {

            return this.CreateCarProduct();

        }
     

    }
}
