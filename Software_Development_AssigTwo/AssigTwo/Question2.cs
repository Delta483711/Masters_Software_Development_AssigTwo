using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    /// <summary>
    /// Conditions & Conditional Statements...
    /// </summary>
    class Question2
    {
        /// <summary>
        /// Method to get the Leap Year 
        /// </summary>
        public void LeapYear()
        {
            Console.Write("\n" + "Enter Year: ");

            int Year = Convert.ToInt32(Console.ReadLine());

            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                Console.WriteLine("\n" + Year + " is a Leap Year!" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + Year + " is NOT a Leap Year" + "\n");
            }
        }

        /// <summary>
        /// Method to Check Date Entered
        /// </summary>
        public void CheckDate()
        {
            DateTime Date;
            DateTime Today = DateTime.Today;
            Console.Write("\n" + "Enter Date: ");
            Date = Convert.ToDateTime(Console.ReadLine());

            if (Date > Today)
            {
                Console.WriteLine("\n" + "Future Date" + "\n");
            }
            else if (Date == Today)
            {
                Console.WriteLine("\n" + "Present Date" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "Past Date" + "\n");
            }
        }

        /// <summary>
        /// Method to check Vote Age.
        /// </summary>
        public void VoteAge()
        {
            Console.Write("\n" + "Enter Desired Age: ");

            int Age;

            Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= 18)
            {
                Console.WriteLine("\n" + "You CAN Vote!" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "You CANNOT Vote!" + "\n");
            }
        }

        /// <summary>
        /// Method to find the biggest number
        /// </summary>
        public void LargestNumber()
        {

            Console.Write("\n" + "Enter the First Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Enter the Secound Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n" + "Enter the Third Number: ");
            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("\n" + Num1 + " is the Biggest Number!" + "\n");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("\n" + Num2 + " is the Biggest Number!" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + Num3 + " is the Biggest Number!" + "\n");
            }
        }


        /// <summary>
        /// Method to Convert Month Number to Month Name
        /// </summary>
        public void ConvertMonth()
        {
            String UserInput;

            Console.Write("\n" + "Enter Month Number: ");
            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    Console.WriteLine("\n" + "January");
                    break;
                case "2":
                    Console.WriteLine("\n" + "Feburary");
                    break;
                case "3":
                    Console.WriteLine("\n" + "March");
                    break;
                case "4":
                    Console.WriteLine("\n" + "April");
                    break;
                case "5":
                    Console.WriteLine("\n" + "May");
                    break;
                case "6":
                    Console.WriteLine("\n" + "June");
                    break;
                case "7":
                    Console.WriteLine("\n" + "July");
                    break;
                case "8":
                    Console.WriteLine("\n" + "August");
                    break;
                case "9":
                    Console.WriteLine("\n" + "September");
                    break;
                case "10":
                    Console.WriteLine("\n" + "October");
                    break;
                case "11":
                    Console.WriteLine("\n" + "November");
                    break;
                case "12":
                    Console.WriteLine("\n" + "December");
                    break;
            }
        }
    }
}
