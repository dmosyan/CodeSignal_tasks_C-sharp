using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal_Arcade
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1: Write a function that returns the sum of two numbers.
            //Example: For param1 = 1 and param2 = 2, the output should be
            //add(param1, param2) = 3.
            int add(int param1, int param2)
            {
                int sum = param1 + param2;
                return sum;
            }

            //TASK2: Given a year, return the century it is in. 
            //The first century spans from the year 1 up to and including the year 100, the second - 
            //from the year 101 up to and including the year 200, etc.
            int centuryFromYear(int year)
            {
                return ((year - 1) / 100) + 1;
            }

            //TASK3: Given the string, check if it is a palindrome.
            //For inputString = "aabaa", the output should be
            //checkPalindrome(inputString) = true;
            bool checkPalindrome(string inputString)
            {
                int length = inputString.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (inputString[i] != inputString[length - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}
