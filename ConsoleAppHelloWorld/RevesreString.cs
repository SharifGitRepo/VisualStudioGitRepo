using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class RevesreString
    {
        public string RevString(string s)
        {
            char[] arr =s.ToCharArray();
            int left = 0, right = arr.Length - 1;

            while(left <right)
            {
                char temp;
                temp=arr[left];
                arr[left]=arr[right];
                arr[right]=temp;

                left++;
                right--;
            }
            return new string(arr);
        }
        public static void Main(string[] args)
        {
            RevesreString revesreString = new RevesreString();
            revesreString.RevString("abc");
        }
    }
}
