using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    //35. Search Insert Position
    //https://leetcode.com/problems/search-insert-position/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11 };
            var result = SearchInsert(arr, 8);

        }

        private static int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == nums[mid])
                    return mid;

                else if (target < nums[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return min;
        }

    }
}
