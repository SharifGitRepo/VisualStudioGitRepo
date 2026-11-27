using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class TeoSumSortedArray
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int sums = numbers[left] + numbers[right];
                if (sums == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                if(sums < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new int[0];
        }
        public  static void Main(string[] args)
        {
            int[] nums = { 2, 11, 7, 15 };
            int target = 9;
            TeoSumSortedArray   teoSumSortedArray = new TeoSumSortedArray();
            teoSumSortedArray.TwoSum(nums, target);

            /* Dry Run
             * int[] nums = {2,7,11,15};
                left = 0
                right = 3
                
                left < right
                
                1st iteration = sums = nums[0] + nums[3]= 17
                17 > target, right-- = right =2
                
                2at iteration = sums = nums[0] + nums[2]=13
                13> target, right--, right=1
                
                3rd iteration = sums= num[0]+sums[1]=9
                so result= left+1, right+1
                1,2
             */
        }
    }
}
