using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task8
    {
        public static int[] LetterCounter(string input)
        {
            input = input.ToLower();
            int[] result = new int[26];
            foreach (char c in input)
            {
               int value = c - 'a';
               result[value]++;
            }
            return result;
        }
    }
}
