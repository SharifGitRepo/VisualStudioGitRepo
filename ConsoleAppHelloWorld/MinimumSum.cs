using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    
    public class MinimumSum
    {
        public int minSum(int target, int[] nums)
        {
            int left = 0,sums=0;
            int minVal = int.MaxValue;

            for(int right =0;right<nums.Length;right++)
            {
                sums = sums + nums[right];
                while(sums >= target)
                {
                    minVal = Math.Min(minVal, right - left + 1);
                    sums = sums - nums[left];
                    left++;
                }
            }
            return minVal == int.MaxValue ? 0 : minVal;
        }

        public static void Main(string[] args)
        {
            MinimumSum min = new MinimumSum();
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };
            min.minSum(target, nums);
        }
    }
}
