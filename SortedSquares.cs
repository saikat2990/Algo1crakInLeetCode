using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class SortedSquares
    {
        public int[] SortedSquares1(int[] nums)
        {
            var data = new int[nums.Length];
            var sortData = new List<int>();
            foreach (var VARIABLE in nums)
            {
                sortData.Add(VARIABLE * VARIABLE);
            }
            sortData.Sort();
            for (int i = 0; i < sortData.Count; i++)
            {
                data[i] = sortData[i];
            }
            return data;
        }
    }
}
