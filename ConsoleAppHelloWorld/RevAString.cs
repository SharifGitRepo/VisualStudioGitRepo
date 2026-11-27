using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class RevAString
    {
        public string RevString(string s)
        {
            char[] charArray = s.ToCharArray();
            int left = 0;
            int right = charArray.Length - 1;

            while(left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right]=temp;
                left++;
                right--;
            }
            return new string(charArray);
        }
        public static void Main(string[] args)
        {
            RevAString revStr = new RevAString();
            revStr.RevString("abc");
        }
        
        
    }
}
