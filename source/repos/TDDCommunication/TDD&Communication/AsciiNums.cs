using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class AsciiNums
    {
        public int addAscii(string input)
        {
            int sum = 0;

            foreach (char c in input)
            {
                sum += (int)c;
            }
            return sum;
        }
        
    }
}
