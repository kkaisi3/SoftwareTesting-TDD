using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class AdvancedTasks
    {
        public static int[] EncodeArray(int[] intArray)
        {
            Dictionary<int, int> dict = new();
            foreach (int num in intArray)
            {
                if (!dict.ContainsKey(num))
                {
                    dict[num] = 0;
                }
                dict[num]++;
            }
            int[] ans = new int[dict.Count * 2];
            int index = 0;
            foreach (var entry in dict)
            {
                ans[index] = entry.Key;
                index++;
                ans[index] = entry.Value;
                index++;
            }
            return ans;
        }
        public static bool IsRotation(string string1, string string2)
        {
            string concat = string1 + string1;
            return concat.Contains(string2);
        }
        public static bool IsMagicSquare(int[,] intArray)
        {
            int n = intArray.GetLength(0);
            int magicConstant = (n * ((n * n) + 1)) / 2;

            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j = 0; j < n; j++) sum += intArray[i, j];
                if (sum != magicConstant) return false;

                sum = 0;
                for (int j = 0; j < n; j++) sum += intArray[j, i];
                if (sum != magicConstant) return false;

                sum = 0;
                for (int j = 0, k = 0; j < n; j++, k++) sum += intArray[j, k];
                if (sum != magicConstant) return false;

                sum = 0;
                for (int j = n - 1, k = 0; j >= 0; j--, k++) sum += intArray[j, k];
                if (sum != magicConstant) return false;
            }
            return true;
        }

    }
}
