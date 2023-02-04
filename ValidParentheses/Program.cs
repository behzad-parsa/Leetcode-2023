using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//20.Valid Parentheses
//https://leetcode.com/problems/valid-parentheses

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string case1 = "()";  //true
            string case2 = "()[]{}"; //true
            string case3 = "(]"; //false
            string case4 = "(("; //false
            string case5 = "))"; //false
            string case6 = "(){}}{"; //false

            Console.WriteLine(IsValid(case1));
            Console.WriteLine(IsValid(case2));
            Console.WriteLine(IsValid(case3));
            Console.WriteLine(IsValid(case4));
            Console.WriteLine(IsValid(case5));
            Console.WriteLine(IsValid(case6));

            Console.ReadLine();
        }


        /*idea :
        every opening brucket will push into stack 
        When you get to a closed bracket, pop the most recent element [which is an opened bracket] and use two lists [or one dictionary] to see if two elements [open and close] are correct. */

        public static bool IsValid1(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }
            
            List<char> openCharList = new List<char>()
            {
                '[',
                '{',
                '('
            };
            List<char> closeCharList = new List<char>()
            {
                ']',
                '}',
                ')'
            };

            //case => ))
            if (closeCharList.Contains(s[0]))
                return false;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (openCharList.Contains(s[i]))
                    stack.Push(s[i]);
                //case => (){}}{
                if (stack.Count == 0 && closeCharList.Contains(s[i]))
                    return false;

                if (closeCharList.Contains(s[i]) && stack.Count > 0)
                {
                    var closeCharIndex = closeCharList.IndexOf(s[i]);
                    var openCharIndex = openCharList.IndexOf(stack.Pop());
                    if (openCharIndex != closeCharIndex)
                        return false;
                }
            }
            if (stack.Count != 0)
                return false;
            return true;
        }
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
                return false;

            //keys = open brackets
            //values = close brack
            Dictionary<char, char> bracketsPair = new Dictionary<char, char>()
            {
                {'[',']' },
                {'{','}' },
                {'(',')' }
            };

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                //case => (){}}{  or ))
                if (stack.Count == 0 && bracketsPair.ContainsValue(s[i]))
                    return false;
                if (bracketsPair.ContainsKey(s[i]))
                    stack.Push(s[i]);
                if (bracketsPair.ContainsValue(s[i]) && stack.Count > 0)
                {
                    var lastElementStack = stack.Pop();
                    if (bracketsPair[lastElementStack] != s[i])
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
