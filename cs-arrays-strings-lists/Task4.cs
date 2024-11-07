using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task4
    {
        public static string ReturnWordsBetweenParentheses(string input)
        {
            string[] parts = input.Split('(');
            string[] parts2 = parts[1].Split(')');
            return parts2[0];
        }
    }
}
