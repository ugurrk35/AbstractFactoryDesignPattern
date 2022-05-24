using AbstractFactoryDesignPattern.ModelFactory;
using System;

namespace AbstractFactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - BMW");
            Console.WriteLine("2 - AUDİ");
            Console.WriteLine("Select number of Menu: ");
            var readLine = Console.ReadLine();
            if (readLine == "1")
            {

                Cars _car = new BMWFactory().CarDetails();
                if (_car != null)
                {
                    Console.WriteLine("Car model : " + _car.GetCarModel());

                    Console.WriteLine("Car color : " + _car.GetColor());

                    Console.WriteLine("Car Price :" + _car.GetCarPrice());
                }
                else
                {
                    Console.Write("Invalid Car Type");
                }
            }

            else if (readLine == "2")
            {

                Cars _car = new AudiFactory().CarDetails();
                if (_car != null)
                {
                    Console.WriteLine("Car model : " + _car.GetCarModel());

                    Console.WriteLine("Car color : " + _car.GetColor());

                    Console.WriteLine("Car Price :" + _car.GetCarPrice());
                }
                else
                {
                    Console.Write("Invalid Car Type");
                }
            }



            Console.WriteLine("--------------");
            Console.ReadLine();
        }
    }
}
