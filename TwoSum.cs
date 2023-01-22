using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class TwoSum
    {
        public static int[] TwoSums(int[] numbers, int target)
        {

            var dictionary = new Dictionary<int, int>();
            var firstIndex = -1;
            var secondIndex = -1;
            for (var index = 0; index < numbers.Length; index++)
            {
                dictionary[numbers[index]] = index;

            }
            for (var index = 0; index < numbers.Length; index++)
            {
                var firstData = numbers[index];
                if (dictionary.ContainsKey(target - firstData))
                {
                    firstIndex = index + 1;
                    secondIndex = dictionary[target - firstData] + 1;
                    return new[] { firstIndex, secondIndex };
                }

            }
            return new[] { firstIndex, secondIndex };
        }
    }
}
