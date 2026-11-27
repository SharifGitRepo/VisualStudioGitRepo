using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    
    internal class ReverseArray
    {
        public int[] RevArray(int[] nums)
        {

            int left = 0;
            int right =nums.Length - 1;
            while(left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right]=temp;
                left++;
                right--;
            }
            return nums;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 8, 0 };
            ReverseArray r = new ReverseArray();
            r.RevArray(nums);
        }
    }
}
