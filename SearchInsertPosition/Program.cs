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
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            var result = BinarySearch(arr,5);



        }

        private static int BinarySearch(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                    return mid;

                else if (key < inputArray[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }
            return -1;
        }
    }
}
