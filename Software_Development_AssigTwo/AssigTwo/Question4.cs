using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    /// <summary>
    /// Array
    /// </summary>
    class Question4
    {
        /// <summary>
        /// Store numbers in array
        /// </summary>
        public int[] StoreArray()
        {
            int Element;

            Console.Write("\n" + "Enter the number of Elements you want to add" + "\n");

            Element = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "Enter " + Element + " Numbers to insert into an Array" + "\n");

            int[] numlist = new int[Element];

            for (int i = 0; i < Element; i++)
            {
                numlist[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            }

            Console.WriteLine("The Numbers in the Array are: " + "[{0}]", string.Join(", ", numlist));

            return numlist;
        }


        /// <summary>
        /// Read numbers in array in reverse.
        /// </summary>
        /// <param name="numlist">he array from the user</param>
        /// <returns></returns>
        public int[] ReadArrayReverse(int[] numlist)
        {
            Console.WriteLine("The Array as normal: " + "[{0}]", string.Join(", ", numlist));

            int[] revsernumlist = numlist;

            Array.Reverse(revsernumlist);

            Console.Write("\n");

            Console.WriteLine("The Array in Reverse: " + "[{0}]", string.Join(", ", revsernumlist));

            return numlist;
        }

        /// <summary>
        /// Method to get the sum of the array.
        /// </summary>
        /// <param name="numlist"> the array from the user</param>
        /// <returns></returns>
        public int[] ArraySum(int[] numlist)
        {
            int Sum = 0;
            for (int i = 0; i < numlist.Count(); i++)
            {

                Sum = Sum + numlist[i];
            }

            Console.WriteLine("\n" + "The Sum of all the numbers in the Array is: " + Sum);

            return null;
        }

        /// <summary>
        /// Method to split the array into separte arrays
        /// one of even numbers 
        /// one of odd numbers
        /// </summary>
        /// <param name="numlist">the array from the user</param>
        /// <returns> Null </returns>
        public int[] EvenOdd(int[] numlist)
        {
            int[] Odd = new int[10];
            int[] Even = new int[10];
            int O = 0;
            int E = 0;

            for (int i = 0; i < numlist.Count(); i++)
              {
                if (numlist[i] % 2 == 0)
                 {
                    Even[E] = numlist[i];
                    E++;

                 }
                else
                {
                    Odd[O] = numlist[i];
                    O++;
                }
             }

            Console.WriteLine("The Odd Numbers are: " + "[{0}]", string.Join(", ", Odd));
            Console.WriteLine("The Even Numbers are: " + "[{0}]", string.Join(", ", Even));

            return null;
        }
    }
}
