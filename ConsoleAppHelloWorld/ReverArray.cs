using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class ReverArray
    {
        public static string RevString(string arr)
        {
            if(arr.Length == 0 || arr == null )
            {
                return null;
            }
            int left = 0;
            char[] s = arr.ToCharArray();
            int right = s.Length - 1;
            while (left<right)
            {
                char temp;
                temp=s[left];
                s[left]=s[right];
                s[right] =temp;

                left++;
                right--;
            }
            return new string(s);
        }
        public static void Main(string[] args)
        {
            RevString("abc");
        }
    }
}
