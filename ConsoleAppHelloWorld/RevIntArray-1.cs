using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class RevIntArray_1
    {
        public int[] RevArray(int[] arr)
        {
            if(arr == null)
            {
                return null;
            }
            int left = 0;
            int right = arr.Length - 1;

            while(left<right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right]=temp;

                left++;
                right--;
            }
            return arr;
        }
        public static void Main(string[] args)
        {
            RevIntArray_1 revIntArray_1 = new RevIntArray_1();
            revIntArray_1.RevArray(new int[] { 1, 2, 3 });
        }
    }
}
