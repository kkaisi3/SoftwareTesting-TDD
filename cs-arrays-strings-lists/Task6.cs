using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task6
    {
        public static string SwapLastInstanceCase(string[] words, string searchString)
        {
            Array.Reverse(words);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(searchString))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in words[i])
                    {
                        if (Char.IsUpper(c))
                        {
                            sb.Append(Char.ToLower(c));
                        }
                    }
                }
            }
            Array.Reverse(words);
            return String.Join(" ", words);
        }
    }
}
