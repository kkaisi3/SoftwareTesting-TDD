using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class CeasarCipher
    {
        public string Ceasarstring(string input)
        {
            string answer = "";
            input = input.ToUpper();
            foreach (char c in input)
            {
                int a = Convert.ToInt32(c);
               a += 13;
                if(a > 90)
                {
                    a = a - 26;
                }

                answer += (char)a;
            }
            answer = answer.ToLower();
            return answer;
        }

    }
}
