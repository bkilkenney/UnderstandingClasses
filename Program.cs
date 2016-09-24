using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating an instance of an object(creating a car, in this example)

            Car instanceOfCar = new Car();     //Need to set the properties of this particular car, and you might want to get that info out

            instanceOfCar.Make = "Toyota";
            instanceOfCar.Model = "Camry";
            instanceOfCar.Year = 2000;          ////SETTING this car's properties
            instanceOfCar.Color = "Beige";      //You SET a properties value with the assignment operator =

            Console.WriteLine("{0}, {1}, {2}, {3}",         //Using placeholders, below determines what each placeholder is holding
                instanceOfCar.Make, 
                instanceOfCar.Model, 
                instanceOfCar.Year, 
                instanceOfCar.Color);           //GETTING this car's properties

            //decimal value = DetermineMarketValue(instanceOfCar); //Calling the method from below with the car parameters above
            // Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", instanceOfCar.DetermineMarketValue());
            
            Console.ReadLine();           
        }

        private static decimal DetermineMarketValue(Car car)  //Creating a method with parameters
        {
            decimal carValue = 100.00M;
            return carValue;
        }
    }
}
