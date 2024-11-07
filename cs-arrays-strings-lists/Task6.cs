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
                if (words[i].ToLower().Contains(searchString.ToLower()))              
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char c in words[i])
                    {
                        if (Char.IsUpper(c))
                        {
                            char temp = Char.ToLower(c);
                            sb.Append(temp);
                        }
                        else
                        {
                            char temp = Char.ToUpper(c);
                            sb.Append(temp);
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
