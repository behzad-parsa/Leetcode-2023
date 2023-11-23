using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    public class Program
    {
        //27. Remove Element
        //https://leetcode.com/problems/remove-element/description/?envType=study-plan-v2&envId=top-interview-150
        static void Main(string[] args)
        {
            //test case 1 
            var nums = new[] { 3, 2, 2, 3 };
            var result = RemoveElement(nums,3);

                    
        }
        public static int RemoveElement(int[] nums,int val)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    counter++;
                    nums[i] = -1;
                }

            }
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums.Length - counter;
        }
    }
}
