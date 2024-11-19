using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class CheeseHunt
    {

        public string Hunting(string raceInput, int catSpeed ,int mouseSpeed)
        {
            /*
             Find a way to find where K M C is in string
            check if K can reach M 
            check if M can reach C
            check if both reach C
             */

            //"---K----M---C--"     CatSpeed 6 MouseSpeed 1

            int wah = 5;
            int catpos = raceInput.IndexOf('K');
            int mousePos = raceInput.IndexOf('M');
            int cheesepos = raceInput.IndexOf('C');


           for (int i = 0;i < raceInput.Length; i++) 
           {
                catpos += catSpeed;
                mousePos += mouseSpeed;


                if(catpos == cheesepos && mousePos == cheesepos)
                {
                    return "Cheese Party";

                }

                if(catpos == mousePos)
                {
                    return "no Cheese";
                }
                if (mousePos == cheesepos)
                {
                    return "Cheese";
                }

            }
            
            
            return "Cheese"; 
        }
    }
}
