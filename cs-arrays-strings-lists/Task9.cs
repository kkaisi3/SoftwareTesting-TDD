using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task9
    {
        public static bool AnagramDetector(string string1, string string2)
        {
            string1 = string1.ToLower();
            string2 = string2.ToLower();
            Dictionary<char, int> dict1 = new();
            Dictionary<char, int> dict2 = new();
            foreach (char c in string1)
            {
                if (!dict1.ContainsKey(c))
                {
                    dict1[c] = 0;
                }
                dict1[c]++;
            }
            foreach (char c in string2)
            {
                if (!dict2.ContainsKey(c))
                {
                    dict2[c] = 0;
                }
                dict2[c]++;
            }
            foreach(var entry in dict1)
            {
                if (!dict2.ContainsKey(entry.Key))
                {
                    return false;
                }
                if (entry.Value != dict2[entry.Key])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
