using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2306.Naming A Company
//https://leetcode.com/problems/naming-a-company/

namespace NamingACompany
{
    class Program
    {
        static void Main(string[] args)
        {
            //case1
            string[] ideas = { "coffee", "donuts", "time", "toffee" };

            //case2 
            string[] ideas2 = { "lack", "back" };

            //case3
            string[] ideas3 = { "aaa", "baa", "caa", "bbb", "cbb", "dbb" };

            

            Console.WriteLine(DistinctNames1(ideas)); //6
            Console.WriteLine(DistinctNames1(ideas2)); //0
            Console.WriteLine(DistinctNames1(ideas3)); //2

            Console.ReadKey();
        }

        //First Algoritm - Pass All test Case But "Time Limit Exceeded" Error
        public static long DistinctNames1(string[] ideas)
        {
            var newNames = new List<string>();

            foreach (var first in ideas)
            {
                foreach (var second in ideas)
                {
                    //the item must not consider with itself
                    if (first.CompareTo(second) == 0)
                        continue;

                    var swapNames = SwapFirstLetter(first, second);

                    //The idea must not include the swapping names.
                    var findNamesResult = ideas.Contains(swapNames[0]) || ideas.Contains(swapNames[1]);

                    if (!findNamesResult)
                        newNames.Add(swapNames[0] + " " + swapNames[1]);
                }
            }

            //Distinct Num of Valid Names
            return newNames.Distinct().Count();
        }

        public static List<string> SwapFirstLetter(string firstWord, string secondWord)
        {
            //string[] swapedWord = new string[2];
            //swapedWord[0] = firstWord.Replace(firstWord[0], secondWord[0]);
            //swapedWord[1] = secondWord.Replace(secondWord[0], firstWord[0]);
            //return swapedWord;
            return new List<string>()
            {
                secondWord[0] + firstWord.Remove(0, 1), //Swaped First Word
                firstWord[0] + secondWord.Remove(0, 1)  //Swaped Second Word
            };
        }
    }
}
