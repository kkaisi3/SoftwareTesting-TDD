using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task2
    {
        public static int FindIndex(string inputToFind, string stringToSearch)
        {
            char[] chars = stringToSearch.ToCharArray();
            char[] charToFind = inputToFind.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == charToFind[0])
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool IsFriendHere(List<string> friends, string friendToFind)
        {
            if (friends.Contains(friendToFind))
            {
                return true;
            }
            return false;
        }
    }
}
