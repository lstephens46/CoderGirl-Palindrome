using System;

namespace Palindrome
{
    public static class Program
    {
       
        public static void Main()
        {
            Console.Write("Please enter a string that you would like to check for palindrome: ");
            string word = Console.ReadLine();

            IsPalindrome(word);
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
            else if(word != reverseString)
            {
                Console.WriteLine(false);
                return false;
            }
            

            
        }


//        The Palindrome assignment is missing some needed details in the instructions.Here they are:
//1. The name of the method you create should be IsPalindrome
//2. The method should take a string as the input.
//3. The method should return a bool - true if the input is a palindrome and false if it is not.
        // TODO: Create a method that recognizes palindromes.
        // The name of the method you create should be IsPalindrome
        // The method should take a string as the input.
        // The method should return a bool - true if the input is a palindrome and false if it is not.
    }
}
