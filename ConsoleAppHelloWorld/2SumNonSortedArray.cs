using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class _2SumNonSortedArray
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i=0;i< nums.Length-1;i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement] + 1, i + 1 };
                }

                map[nums[i]] = i;
            }
            return new int[0];
        }
        public static void Main(string[] args)
        {
            int[] nums = { 2, 15, 13,7, 19, 23 };
            int target = 9;

            _2SumNonSortedArray _2SumNonSortedArray = new _2SumNonSortedArray();
            _2SumNonSortedArray.TwoSum(nums, target);
        }
    }
}
