using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class SearchInsertCode
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length;
            while (right > left)
            {
                var mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target && ((mid + 1 < nums.Length && nums[mid + 1] > target) || (mid + 1 == nums.Length && nums[mid] < target)))
                {
                    return mid + 1;
                }

                if (nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }

            }
            return right;
        }
        static void Main2(string[] args)
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(SearchInsert(nums, 1));
        }
    }
}
