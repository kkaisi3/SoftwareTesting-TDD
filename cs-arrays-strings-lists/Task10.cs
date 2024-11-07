using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task10
    {
        public static Dictionary<int, int> FrequencyCounting(int[] intsToCount)
        {
            Dictionary<int, int> freqDict = new Dictionary<int, int>();
            foreach (int number in intsToCount)
            {
                if (freqDict.ContainsKey(number))
                {
                    freqDict[number]++;
                }
                else
                {
                    freqDict[number] = 1;
                }
            }
            return freqDict;

        }
    }
}
