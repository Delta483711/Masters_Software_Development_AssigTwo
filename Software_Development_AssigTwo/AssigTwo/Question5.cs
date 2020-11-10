using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigTwo
{
    /// <summary>
    /// Functions
    /// </summary>
    class Question5
    {

        /// <summary>
        /// Method to Get user to type name 
        /// </summary>
        /// <returns> the Users Name</returns>
        public string GetName(string Name)
        {

            string Result = "Hello " + Name;

            return Result;
        }   

        /// <summary>
        /// Method to Get the prodcut of two numbers 
        /// </summary>
        /// <returns>Product of two number</returns>
        public int ProductOfTwo(int Number1 , int Number2)
        {
      
          int  Product = Number1 * Number2;

            return Product;
        }

        /// <summary>
        /// Method to get the price and VAT
        /// </summary>
        /// <returns> Price with VAT inc</returns>
        public Double PriceAndVAT(Double Price, int Vat )
        {
            Double Result;

            Result = Price * Vat / 100;

            Result = Price + Result;

            return Result;
        }

        /// <summary>
        /// Method to Calculate secounds since midnight 
        /// </summary>
        /// <returns> Number of Seconds </returns>
        public int SecSinceMidnight(int Hrs, int Mins, int Sec)
        {
            int ConvertToSec = Sec + (Mins * 60) + (Hrs * 60 * 60);

            int Midnight = 59 + (59 * 60) + (24 * 60 * 60);
          
            int Result = Midnight - ConvertToSec;

            return Result;
        }

        /// <summary>
        /// Method to find out if the word entered is Palindrome 
        /// </summary>
        /// <returns>True or false</returns>
        public string GetPalindrome(string Word) 
        {

            string PalindromeWord = "";
            string Status = "";
            
            // Loop to get reverse of Word.
            for (int i = Word.Length - 1; i >= 0; i--) 
            {
                PalindromeWord += Word[i].ToString();
            }

            //Check for PalindromeWord.
            if (Word.Equals(PalindromeWord))
            {
                Status = " IS Palindrome";
            }
            else
            {
                Status = " IS NOT Palindrome";
            }

            return Status;
        }
     }
}
