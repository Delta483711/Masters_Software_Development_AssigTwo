using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    class Question7
    {
        public int Cal()
        {
            int Result = 0;

            Console.WriteLine("Type  One of the Four Basic operators...");

            string Input = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter 1st Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            switch (Input)
            {
                case "+":
                    Console.WriteLine("\n" + Num1 + " + " + Num2 + "\n");
                    Result = Num1 + Num2;
                    break;

                case "-":
                    Console.WriteLine("\n" + Num1 + " - " + Num2 + "\n");
                    Result = Num1 - Num2;
                    break;

                case "*":
                    Console.WriteLine("\n" + Num1 + " * " + Num2 + "\n");
                    Result = Num1 * Num2;
                    break;

                case "/":
                    Console.WriteLine("\n" + Num1 + " / " + Num2 + "\n");
                    Result = Num1 / Num2;
                    break;
            }

            return Result;
        }
    }
}
