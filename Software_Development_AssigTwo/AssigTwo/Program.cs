using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate class.
            Program P = new Program();

            bool repeat = false;
            String UserReply;

            do
            {
                Console.WriteLine("  Choose one of the following: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1 - Statements & Sequences...");
                Console.WriteLine("2 - Conditions & Conditional Statements...");
                Console.WriteLine("3 - Iteration...");
                Console.WriteLine("4 - Arrays...");
                Console.WriteLine("5 - Functions...");
                Console.WriteLine("6 - Classes...");
                Console.WriteLine("7 - Calculator");

                UserReply = P.QuestionUserReply();

                Console.WriteLine("\n" + "  Press Y to run another program. ");

                UserReply = Console.ReadLine();

                if (UserReply.ToUpper() == "Y")
                {
                    repeat = true;
                    Console.WriteLine("\n");
                }
                else
                {
                    repeat = false;
                    Console.WriteLine("Thank You!!!");
                    Console.ReadKey();
                }

            } while (repeat == true);
        }

        /// <summary>
        /// Method for the interface
        /// </summary>
        /// <returns> User Response </returns>
        public String QuestionUserReply()
        {

            //Instantiate Classes for Questions
            Question1 Q1 = new Question1();
            Question2 Q2 = new Question2();
            Question3 Q3 = new Question3();
            Question4 Q4 = new Question4();
            Question5 Q5 = new Question5();
            Rectangle rec = new Rectangle();
            Question7 Q7 = new Question7();

            String input;

            input = Console.ReadLine();

            Console.Write("\n");

            if (input == "1")
            {
                Console.WriteLine("  Choose one of the following:");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("A - Conversion Pound To Dollar");
                Console.WriteLine("B - Conversion Farenheit To Celcius");
                Console.WriteLine("C - Conversion Celcius To Farenheit");
                Console.WriteLine("D - Average of Four Numbers");
                Console.WriteLine("E - Price Discount");

                input = Console.ReadLine().ToUpper();
                Console.Write("\n");

                //Switch for Choosing Progam 
                switch (input)
                {
                    case "A":
                        Console.WriteLine("A) Conversion Pound To Dollar");
                        Q1.ConversionPoundToDollar();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case "B":
                        Console.WriteLine("B) Conversion Farenheit To Celcius ");
                        Q1.ConversionFarenheitToCelcius();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case "C":
                        Console.WriteLine("C) Conversion Celcius To Farenheit ");
                        Q1.ConversionCelciusToFarenheit();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case "D":
                        Console.WriteLine("D) Average of Four Numbers");
                        Q1.GetAverage();
                        Console.WriteLine("---------------------------------------");
                        break;

                    case "E":
                        Console.WriteLine("E) Price Discount ");
                        Q1.GetPriceDiscount();
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }

            if (input == "2")
            {
                Console.WriteLine("  Choose one of the following:");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("A - Leap Year: Find out if the year entered is a Leap Year");
                Console.WriteLine("B - Check Date: Find out of the date enterted is the past, present or future ");
                Console.WriteLine("C - Voting Age: find out if you can vote");
                Console.WriteLine("D - Largest Numnber");
                Console.WriteLine("E - Convert Month");

                input = Console.ReadLine().ToUpper();
                Console.Write("\n");

                //Switch for Choosing Progam 
                switch (input)
                {
                    case "A":
                        Console.WriteLine("A) Leap Year ");
                        Q2.LeapYear();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "B":
                        Console.WriteLine("B) Check Date ");
                        Q2.CheckDate();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "C":
                        Console.WriteLine("C) Voting Age ");
                        Q2.VoteAge();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "D":
                        Console.WriteLine("D) Largest Numnber  ");
                        Q2.LargestNumber();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "E":
                        Console.WriteLine("E) Convert Month  ");
                        Q2.ConvertMonth();
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }

            if (input == "3")
            {
                Console.WriteLine("  Choose one of the following:");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("A - Print Alphabet");
                Console.WriteLine("B - Print Alphabet Backwards");
                Console.WriteLine("C - Print Every 2nd Alphabet");
                Console.WriteLine("D - Half Number: find out how many times a number entered can be halved before it becomes 0");
                Console.WriteLine("E - Number Generator");

                input = Console.ReadLine().ToUpper();
                Console.Write("\n");

                //Switch for Choosing Progam 
                switch (input)
                {
                    case "A":
                        Console.WriteLine("A) Print Alphabet ");
                        Q3.AlphabetPrint();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "B":
                        Console.WriteLine("A) Print Alphabet in Reverse");
                        Q3.AlphabetBackwards();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "C":
                        Console.WriteLine("C) Print 2nd Letter in Alphabet");
                        Q3.SecondLetter();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "D":
                        Console.WriteLine("D - Half Number");
                        Q3.HalfNumber();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "E":
                        Console.WriteLine("E) Number Generator.");
                        Q3.NumberGenetator();
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }

            if (input == "4")
            {

                int[] arraylist = new int[5];

                Console.WriteLine("A) Store Number in Array ");
                arraylist = Q4.StoreArray();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n");

                Console.WriteLine("B - Array Reveres");
                Console.WriteLine("---------------------------------------");
                Q4.ReadArrayReverse(arraylist);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n");

                Console.WriteLine("C - Array Sum");
                Console.WriteLine("---------------------------------------");
                Q4.ArraySum(arraylist);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n");


                Console.WriteLine("D - Seperate Odd and Even");
                Console.WriteLine("---------------------------------------");
                Q4.EvenOdd(arraylist);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("\n");

                //Switch for Choosing Progam 
                /*
                switch (input)
                {
                    case "A":
                        Console.WriteLine("A) Store Element in Array ");
                        arraylist = Q4.StoreArray();
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "B":
                        Console.WriteLine("B) Read Array in Reverse");
                        Q4.ReadArrayReverse(arraylist);
                        Console.WriteLine("---------------------------------------");
                        break;
                    case "C":
                        Console.WriteLine("C) Sum of All Array ");

                        Console.WriteLine("---------------------------------------");
                        break;
                    case "D":
                        Console.WriteLine("D) Seperate Odd and Even in Array  ");

                        Console.WriteLine("---------------------------------------");
                        break;
                }

            */

            }

            if (input == "5")
            {
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("A - Hello Function");
                Console.WriteLine("B - Product of Two Numbers ");
                Console.WriteLine("C - Price & VAT");
                Console.WriteLine("D - Seconds Since Midnight");
                Console.WriteLine("E - Get Palindrome");

                input = Console.ReadLine().ToUpper();

                //Switch for Choosing Progam 
                switch (input)
                {
                    case "A":

                        Console.Write("\n" + "Enter Your Full Name: ");
                        string Name = Console.ReadLine();
                        Console.WriteLine("\n" + Q5.GetName(Name) + "\n");
                        Console.WriteLine("---------------------------------------");

                        break;

                    case "B":

                        Console.Write("\n" + " Enter the First Number: ");
                        int Num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n" + " Enter the Second Number: ");
                        int Num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\n" + " The Product is: " + Q5.ProductOfTwo(Num1, Num2) + "\n");
                        Console.WriteLine("---------------------------------------");

                        break;

                    case "C":

                        Console.Write("\n" + "Enter the Price : £");
                        Double Price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("\n" + " Enter the VAT(%) : ");
                        int Vat = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n" + " The Price inc VAT is: £" + Q5.PriceAndVAT(Price, Vat) + "\n");

                        break;

                    case "D":

                        Console.WriteLine("Enter Hour: ");
                        int Hour = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Minutes: ");
                        int Minutes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Seconds: ");
                        int Seconds = Convert.ToInt32(Console.ReadLine());

                       Console.WriteLine("\n" + "Total Seconds Since Midnight Is: " + Q5.SecSinceMidnight(Hour, Minutes, Seconds)+"s");
                       Console.WriteLine("---------------------------------------");

                        break;

                    case "E":
                        Console.Write("\n" + "Enter a Word: ");
                        string Word = Console.ReadLine();
                        Console.WriteLine("\n" + Word + Q5.GetPalindrome(Word));
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }

            if (input == "6")
            {
                int height;

                int width;

                Console.WriteLine("Create a Rectangle..." + "\n");

                Console.Write("Enter Height (cm): ");

                height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                Console.Write("Enter Width (cm): ");

                width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");

                Console.WriteLine("Area: " + rec.Area(height, width) + "cm²");

                Console.WriteLine("\n");

                Console.WriteLine("---------------------------------------");
            }

            if (input == "7")
            {
                Console.WriteLine("Result " + Q7.Cal());

            }

            return input;
        }
    }
}
