using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task5
    {
        public static List<string> RemoveWordStartingWithVowel(List<string> words)
        {
            List<char> vowels = [ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' ];
            List<string> answer = new();
            foreach (string word in words)
            {
                if (vowels.Contains(word[0]))
                {
                    continue;
                }
                else
                {
                    answer.Add(word);
                }
            }
            return answer;
        }
    }
}

