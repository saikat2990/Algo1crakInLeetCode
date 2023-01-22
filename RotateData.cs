using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class RotateData
    {
        public static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                var temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            //var remainder = nums.Length < k ? k % nums.Length : k;
            //var dictionary = new Dictionary<int, int>();
            //var temporal = new int[nums.Length];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    var index = (i + remainder) % (nums.Length);
            //    dictionary[nums[i]] = index;
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    temporal[dictionary[nums[i]]] = nums[i];
            //}

            //nums = temporal;
            //for (int i = 0; i < temporal.Length; i++)
            //{
            //    nums[i] = temporal[i];
            //}
            //var remainder = nums.Length < k ? k % nums.Length : k;
            //if (remainder != 0)
            //{
            //    var indexArray = new List<int>();
            //    indexArray.Add(0);
            //    var contains = nums[0];
            //    while (indexArray.Count<=nums.Length)
            //    {
            //        var nextIndex = ((indexArray[^1]+remainder)>=nums.Length? (indexArray[^1] + remainder) - nums.Length: indexArray[^1] + remainder);
            //        if (!indexArray.Contains(nextIndex))
            //        {
            //            var tempcontains = nums[nextIndex];
            //            nums[nextIndex] = contains;
            //            contains = tempcontains;
            //            indexArray.Add(nextIndex);
            //        }
            //        else
            //        {
            //            nums[nextIndex] = contains;
            //            nextIndex += 1;
            //            while (indexArray.Contains(nextIndex))
            //            {
            //                nextIndex += 1;
            //            }

            //            nextIndex = nextIndex % nums.Length;
            //            contains = nums[nextIndex];
            //            indexArray.Add(nextIndex);
            //        }


            //    }
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
            foreach (var VARIABLE in nums)
            {
                Console.WriteLine(VARIABLE);
            }

        }

        static void Main3(string[] args)
        {
            var nums = new int[] { -1, -100, 3, 99 };
            Rotate(nums, 2);
        }
    }
}
