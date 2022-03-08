using System;
using System.Text;

namespace FindAllSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to Find All Substrings of a Given String");
            //Input: ABC
            //Output: A, AB, ABC, B, BC, C, CD, D

            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < inputString.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(inputString.Length - i);
                for (int j = i; j < inputString.Length; ++j)
                {
                    subString.Append(inputString[j]);
                    Console.Write(subString + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
