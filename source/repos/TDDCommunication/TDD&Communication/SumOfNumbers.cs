﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class SumOfNumbers
    {
        public int AddNumbers(int[] numbers)
        {
            Array.Sort<int>(numbers);

            int sum = 0;

            for(int i = 1; i < numbers.Length - 1; i++)
            {
                sum += numbers[i];
            }

            return sum;

            
            
            


        }
    }
}
