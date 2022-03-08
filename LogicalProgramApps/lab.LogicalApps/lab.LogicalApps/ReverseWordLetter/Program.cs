using System;
using System.Linq;

namespace ReverseWordLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to reverse the order of words in a given string");
            //Input: Welcome to Csharp corner
            //Output: corner Csharp to Welcome

            var inputWordArr = "Welcome to Csharp corner".Split(" ").ToArray();

            int end = inputWordArr.Length - 1;

            string output = string.Empty;

            for (int i = 0; i < inputWordArr.Length; i++)
            {
                string temp = inputWordArr[end].Trim();

                output += temp + " ";
                end--;
            }

            Console.WriteLine(output);

            Console.WriteLine("How to reverse the order of letter in a given string");
            //Input: Welcome
            //Output: emocleW

            var inputLetterArr = "Welcome".ToCharArray();

            int endLetter = inputLetterArr.Length - 1;

            string outputLetter = string.Empty;

            for (int i = 0; i < inputLetterArr.Length; i++)
            {
                string temp = inputLetterArr[endLetter].ToString();

                outputLetter += temp;
                endLetter--;
            }

            Console.WriteLine(outputLetter);

            Console.ReadLine();
        }

    }
}
