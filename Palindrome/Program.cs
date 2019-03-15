using System;

namespace Palindrome
{
    public static class Program
    {
       
        public static void Main()
        {
            Console.Write("Please enter a string that you would like to check for palindrome: ");
            string test = Console.ReadLine();

            IsPalindrome(test);
            Console.ReadLine();
        }

        public static bool IsPalindrome(string word)
        {   //Create a variable to store the reversed string
            string reverseString;

            //turn word into a char.Array
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);


            reverseString = new string(charArray);
            //Console.WriteLine(charArray);
            if (word == reverseString)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
              Console.WriteLine(false);
                return false;
            }


           
           


        }

    }
}





