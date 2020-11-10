using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    class Question1
    {
        /// <summary>
        /// Method to Convert Pounds to Dollars.
        /// </summary>
        public void ConversionPoundToDollar()
        {
            Double Pound;
            Double Dollar;

            Console.Write("\n" + "Enter Pound: £");
            Pound = Convert.ToDouble(Console.ReadLine());

            Dollar = Pound * 1.4;
            
            Console.WriteLine("\n" + "Result: " + "$" + Math.Floor(Dollar) + "\n");
        }

        /// <summary>
        /// Method to Convert Farenheit To Celcius
        /// </summary>
        public void ConversionFarenheitToCelcius()
        {
            Double F;
            Double C;

            Console.Write("\n" + "Enter Farenheit: ");

            F = Convert.ToDouble(Console.ReadLine());

            C = F - 32 / 1.8;

            Console.WriteLine("\n" + "Result: " + Math.Floor(C) + "°C" + "\n");
        }

        /// <summary>
        /// Method to Convert Celcius To Farenheit
        /// </summary>
        public void ConversionCelciusToFarenheit()
        {
            Double C;
            Double F;

            Console.Write("\n" + "Enter Celcius:");

            C = Convert.ToDouble(Console.ReadLine());

            F = C * 1.8 - 32;

            Console.WriteLine("\n" + "Result: " + Math.Floor(F) + "°F" + "\n");
        }

        /// <summary>
        /// Method to get the Average of inputted number.
        /// </summary>
        public void GetAverage()
        {
            int Num1;
            int Num2;
            int Num3;
            int Num4;
            double Average;

            Console.Write("\n" + "Enter the First number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + "Enter the Secound number:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + "Enter the Third number:");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n" + "Enter the Fourth number:");
            Num4 = Convert.ToInt32(Console.ReadLine());

            Average = Num1 + Num2 + Num3 + Num4 / 4;

            Console.WriteLine("\n" + "The Average is: " + Average + "\n");
        }

        /// <summary>
        /// Method to get discount price
        /// </summary>
        public void GetPriceDiscount()
        {
            int Price;
            int Percentage;
            double Total;

            Console.Write("\n" + "Enter the Price : £");
            Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Enter the Percentage(%): ");
            Percentage = Convert.ToInt32(Console.ReadLine());

            Total = Price * Percentage / 100;
            Total = Price - Total;
            Console.WriteLine("\n" + "The Result is: £" + Total + "\n");
        }
    }
}
