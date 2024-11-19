using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Communication
{
    public class LIKEDISLIKE
    {
        public bool IslikeButton = false;
        public bool IsDislikeButton = false;

        public string buttonspressed(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "LIKE")
                {
                    IslikeButton = !IslikeButton;
                }
                else if (text[i] == "DISLIKE")
                {
                    IsDislikeButton= !IsDislikeButton;
                }
            }
            if (IslikeButton && IsDislikeButton) {
                return "NEUTRAL";
            }
            if (IslikeButton == true)
            {

                return "LIKE";
            }
            else if (IsDislikeButton == true)
            {
                return "DISLIKE";
            }
            else
            {
                return "NEUTRAL";
            }

            
        }



        /*
          public string Buttonstatus(enum button)
            {
        
                if(button == like)
                {
                    if(islikebutton == true)
                        {
                           return "like"
                        }
                    else if(islikebutton == false)
                        {
                            return "Neutral"
                            
                        }
                }if(button == dislike)
                {
                    if(isdislikebutton == true)
                        {
                           return "dislike"
                        }
                    else if(islikebutton == false)
                        {
                            return "Neutral"
                            
                        }
                }

                  
        
        }


        }
         
         
         
         
         */


    }
}
