using System;
using System.Collections.Generic;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var myCar = new Car();
           myCar.Make = "Mazda";
           myCar.Model = "Protege";
           myCar.Year = 2010;

            var toyota = new Car()
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2000,
            };
            var dodge = new Car()
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 2005,
            };
       
            var carList = new List<Car>() { myCar, toyota, dodge };
            Console.WriteLine(carList.Count);
            
            foreach (var car in carList)
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
        }
    }
}
