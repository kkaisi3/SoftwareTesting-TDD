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
                bool found = false;

                for (int j = 0; j < searchString.Length; j++)
                {
                    if (searchString[j] != words[i][j])
                    {
                        break;
                    }
                    if (j == searchString.Length - 1)
                    {
                        found = true;
                    }
                }

                if (found == true)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in words[i])
                    {
                        if (Char.IsUpper(c))
                        {                      
                            sb.Append(Char.ToLower(c));
                        }
                        else
                        {
                            sb.Append(Char.ToUpper(c));
                        }
                    }
                    words[i] = sb.ToString();
                    break;
                }
            }
            Array.Reverse(words);
            return String.Join(" ", words);
        }
    }
}
