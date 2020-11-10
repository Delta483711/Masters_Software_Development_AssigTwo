using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{

    /// <summary>
    /// Question 3 - Iteration
    /// </summary>
    class Question3
    {
        /// <summary>
        /// Method to Print Alphabets
        /// </summary>
        public void AlphabetPrint()
        {
            int a;
            int z = 90;
       
            for (a=65; a < z; a++)
            {
                String A = ((char)a).ToString();
                Console.WriteLine(   A);
            }
        }

        /// <summary>
        /// Method to Print the Alphabets Backwards
        /// </summary>
        public void AlphabetBackwards()
        {

            int z = 90;

            for (int i = z;  i >= 65; i--)

            {
                String Z = ((char)i).ToString();
                Console.WriteLine(Z);
            }
        }

        /// <summary>
        /// Method to Print every 2nd Letter in the alphabet
        /// </summary>
        public void SecondLetter()
        {

            int a;
            int z = 90;

            for (a = 65; a < z; a+=2)
            {
                String A = ((char)a).ToString();
                Console.WriteLine(A);
            }
        }

        /// <summary>
        /// Method to Enter Number &
        /// find how many times the number can be halved before it becomes smaller than 1 
        /// </summary>
        public void HalfNumber()
        {

            int Num;
            bool Result = false;
            int Count = 0;

            Console.Write("\n" + "Enter a Number: ");
            Num = Convert.ToInt32(Console.ReadLine());

            do
            {
                Num = Num / 2;
                Count++;

                if (Num == 0)
                {
                    Result = true;
                }
            } while (Result == false);

            Console.WriteLine("\n" + "The number entered was halved " + Count + " times before it reached 0");
        }

        /// <summary>
        /// Method to Ask the user to guess,
        /// and prompt with 
        /// “Too High” or “Too Low” until they guess it correctly
        /// </summary>
        public void NumberGenetator()
        {
            Random random = new Random();
            int UserInput;
            int Num = random.Next(10);
            bool Result = false;

            Console.Write("Enter a Number Between 0 and 10: ");
            UserInput = Convert.ToInt32(Console.ReadLine());
            while (Result == false)
            {
                if (UserInput > Num)
                {
                    Console.WriteLine("is a High Guess, Try Guessing Lower!");
                    UserInput = Convert.ToInt32(Console.ReadLine());

                }
                else if (UserInput < Num)
                {
                    Console.WriteLine("is a Low Guess, Try Guessing Higher!");
                    UserInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("is the Correct Guess!! " + "\n" + "\n" + "Well Done!!" + "\n");
                    Result = true;
                }
            }
        }
    }
}
