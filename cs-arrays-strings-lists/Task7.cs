using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task7
    {
        public static string SecretMessageDecoder(string[] words1, string[] words2)
        {
            List<string> result = new List<string>();
            for (int i = 0; i <words1.Length; i++ )
            {
                words1[i] = words1[i].Trim();
                words2[i] = words2[i].Trim();
                if (words1[i] == words2[i] && words1[i].Length < 7)
                {
                    result.Add(words1[i]);
                }

            }
            result.Reverse();
            return String.Join(" ", result);
        }

    }
}
