using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBadge1
{
    internal class LengthOfLongestSubstring
    {
        public static int LengthOfLongestSubstring1(string s)
        {
            var characterList = new List<char>();
            var characterDictionary = new Dictionary<char, int>();
            var numberOfTimesOccurs = new List<int>();
            char[] characterArray = s.ToCharArray();
            var iteratedData = 0;
            foreach (var ch in characterArray)
            {
                if (characterList.Contains(ch))
                {
                    iteratedData = 0;
                    var index = characterDictionary[ch] + 1;
                    characterDictionary.Clear();
                    var tempChaList = new List<char>();
                    numberOfTimesOccurs.Add(characterList.Count);
                    for (; index < characterList.Count; index++)
                    {
                        characterDictionary[characterList[index]] = iteratedData;
                        iteratedData++;
                        tempChaList.Add(characterList[index]);
                    }
                    characterList = tempChaList;
                    characterList.Add(ch);
                    characterDictionary[ch] = iteratedData;
                    iteratedData++;
                }
                else
                {
                    characterDictionary[ch] = iteratedData;
                    iteratedData++;
                    characterList.Add(ch);
                }
            }
            numberOfTimesOccurs.Add(characterList.Count);
            return numberOfTimesOccurs.Max();
        }

    }
}
