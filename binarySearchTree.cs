using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class binarySearchTree
    {
        private static int binarySearch(int[] nums, int right, int left, int target, int index)
        {
            int mid = (right + left) / 2;
            if (nums[mid] == target) return mid;
            if (right < mid && index == -1)
                index = binarySearch(nums, right, mid, target, index);
            if (mid < left && index == -1)
                index = binarySearch(nums, mid + 1, left, target, index);
            return index;
        }

        public static int Search(int[] nums, int target)
        {
            return binarySearch(nums, 0, nums.Length - 1, target, -1);
        }
        static void Main1(string[] args)
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Search(nums, 9));
        }
    }
}
