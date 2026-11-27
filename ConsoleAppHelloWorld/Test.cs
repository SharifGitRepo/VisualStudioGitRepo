using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class Test
    {
        public int minSum(int target, int[] nums)
        {
            int left = 0, sums = 0;
            //int minVal = int.MaxValue;
            int maxValue = int.MinValue;

            for (int right = 0; right < nums.Length; right++)
            {
                sums = sums + nums[right];
                while (sums >= target)
                {
                    maxValue = Math.Max(maxValue, right - left + 1);
                    sums = sums - nums[left];
                    left++;
                }
                

            }
            return maxValue == int.MinValue ? 0 : maxValue;
        }
        public static void Main(string[] args)
        {
            Test min = new Test();
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            min.minSum(target, nums);
        }
    }
}
