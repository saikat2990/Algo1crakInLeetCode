using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class CheckInclusionSoluation
    {
        private static bool IsAllZeros(int[] budgets)
        {

            for (int i = 0; i < 26; i++)
            {
                if (budgets[i] != 0) return false;
            }
            return true;
        }

        public static bool CheckInclusion(string s1, string s2)
        {

            if (s1.Length > s2.Length) return false;
            var budgets = new int[26];
            for (var i = 0; i < 26; i++)
            {
                budgets[i] = 0;
            }

            for (var i = 0; i < s1.Length; i++)
            {
                budgets[s1[i] - 'a'] += 1;
                budgets[s2[i] - 'a'] -= 1;
            }
            if (IsAllZeros(budgets)) return true;

            var s1Length = s1.Length;

            for (var j = s1Length; j < s2.Length; j++)
            {
                budgets[s2[j - s1Length] - 'a'] += 1;
                budgets[s2[j] - 'a'] -= 1;
                if (IsAllZeros(budgets)) return true;
            }



            //var actualStringDictionary = new Dictionary<char, int>();
            //var actualDiff = 0;
            //var tempStringDictionary = new Dictionary<char, int>();
            //foreach (var ch in s1.ToCharArray())
            //{
            //    if (actualStringDictionary.ContainsKey(ch))
            //    {
            //        actualStringDictionary[ch]++;
            //    }
            //    else
            //    {
            //        actualDiff++;
            //        actualStringDictionary[ch] = 1;
            //    }
            //}

            //var foundCount = 0;
            //var foundDiff = 0;
            //var index = 0;
            //foreach (var s2Char in s2.ToCharArray())
            //{

            //    if (actualStringDictionary.ContainsKey(s2Char))
            //    {
            //        if (tempStringDictionary.ContainsKey(s2Char))
            //        {
            //            tempStringDictionary[s2Char]++;
            //            foundCount++;
            //        }
            //        else
            //        {
            //            tempStringDictionary[s2Char] = 1;
            //            foundCount++;
            //            foundDiff++;
            //        }

            //        if (tempStringDictionary[s2Char] > actualStringDictionary[s2Char])
            //        {
            //            if (foundDiff == 1)
            //            {
            //                tempStringDictionary[s2Char]--;
            //                foundCount--;
            //            }
            //            else
            //            {
            //                var allVertices = false;
            //                var totalOccur = tempStringDictionary[s2Char];
            //                for (var i = 0; i < totalOccur; i++)
            //                {
            //                    if (s2[index - i] == s2Char)
            //                    {
            //                        allVertices = true;
            //                    }
            //                    else
            //                    {
            //                        allVertices = false;
            //                        break;
            //                    }
            //                }
            //                if (allVertices)
            //                {
            //                    tempStringDictionary.Clear();
            //                    tempStringDictionary[s2Char] = actualStringDictionary[s2Char];
            //                    foundCount = actualStringDictionary[s2Char];
            //                    foundDiff = 1;
            //                }
            //                else
            //                {
            //                    tempStringDictionary[s2Char]--;
            //                    foundCount--;
            //                }

            //            }

            //        }
            //        if (foundDiff == actualDiff && foundCount == s1.Length)
            //            return true;
            //    }
            //    else
            //    {
            //        tempStringDictionary.Clear();
            //        foundCount = 0;
            //        foundDiff = 0;
            //    }
            //    index++;
            //}



            return false;
        }
    }
}
