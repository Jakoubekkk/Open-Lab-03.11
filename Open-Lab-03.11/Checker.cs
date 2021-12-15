using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);

            if (new String(array) == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}  
        
       
