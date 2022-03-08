using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not.");
            //Input: madam, Output: Palindrome
            //Input: step on no pets, Output: Palindrome
            //Input: book, Output: Not Palindrome

            //Console.Write("Enter a String : ");
            //string inputString = Console.ReadLine();
            string inputString = "step on no pets";

            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            string inputStringReverse = new string(arr);

            if (inputString.Equals(inputStringReverse))
            {
                Console.Write("Palindrome");
            }
            else
            {
                Console.Write("Not Palindrome");
            }

            Console.ReadLine();
        }
    }
}
