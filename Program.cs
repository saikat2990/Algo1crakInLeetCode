namespace AlgorithmBadge1
{
    internal class Program
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            var actualStringDictionary  = new Dictionary<char, int>();
            var actualDiff = 0;
            var tempStringDictionary = new Dictionary<char, int>();
            foreach (var ch in s1.ToCharArray())
            {
                if (actualStringDictionary.ContainsKey(ch))
                {
                    actualStringDictionary[ch]++;
                }
                else
                {
                    actualDiff++;
                    actualStringDictionary[ch] = 1;
                }
            }

            var foundCount = 0;
            var foundDiff = 0;
            foreach (var s2Char in s2.ToCharArray())
            {
                if (actualStringDictionary.ContainsKey(s2Char))
                {
                    if (tempStringDictionary.ContainsKey(s2Char))
                    {
                        if (tempStringDictionary[s2Char] > actualStringDictionary[s2Char])
                        {
                            tempStringDictionary[s2Char] -= 1;
                            foundCount--;
                            continue;
                        }
                        tempStringDictionary[s2Char]++;
                        foundCount++;
                    }
                    else
                    {
                        tempStringDictionary[s2Char] = 1;
                        foundCount++;
                        foundDiff++;
                    }

                   

                    
                    if (foundDiff == actualDiff && foundCount==s1.Length)
                        return true;
                }
                else
                {
                    tempStringDictionary.Clear();
                    foundCount=0;
                    foundDiff = 0;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInclusion("adc", "dcda"));
        }
    }
}