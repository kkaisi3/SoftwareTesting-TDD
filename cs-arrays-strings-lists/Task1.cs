using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task1
    {
        public static int[] ArraySort(int[] arrayToSort)
        {
            Array.Sort(arrayToSort);
            return arrayToSort;
        }
        public static string ShoutString(string stringToShout)
        {
            return stringToShout.ToUpper();
        }
    }
}

