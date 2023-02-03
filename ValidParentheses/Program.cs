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
            //Stack s = new Stack();
            //s.Push("stg");
            //s.Push(4);
            //s.Push(null);
            //s.Push(5);
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
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
        When you get to a closed bracket, pop the most recent element [which is an opened bracket] and use two lists to see if two elements [open and close] are correct. */
        public static bool IsValid(string s)
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

            if (closeCharList.Contains(s[0]))
                return false;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (openCharList.Contains(s[i]))
                    stack.Push(s[i]);
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
        
    }
}
