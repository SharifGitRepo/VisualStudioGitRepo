using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class LongestNonRepeatingSunStringInAString
    {
        public int LongestSubString(string s)
        {
            int left = 0, maxLen = 0;
            HashSet<char> set = new HashSet<char>();

            for(int right =0; right < s.Length;right ++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            return maxLen;
         }
        public static void Main(string[] args)
        {

            HashSet<char> set = new HashSet<char>();
            set.Add('a');
            set.Add('b');
            set.Add('c');
            set.Remove('a');
            set.Add('a');


            string s = "abcabcbb";
            LongestNonRepeatingSunStringInAString longestNonRepeatingSunStringInAString = new LongestNonRepeatingSunStringInAString();
            longestNonRepeatingSunStringInAString.LongestSubString(s);

            // a b c a b c b b // 8 char
            //ist iteration, not present in set, so add into set set = a
            //2nd itearion, not present in the set so add into the set = ab
            //3rd iteration not present in the et so add into the set = abc

            //4th iteration, set.Remove(s[left]), left=0, set=bc, set.Add(s[right]), set = bca, sorted to abc
            //5th iteration b is present in the set, so Remove s[left], here left =1, so c remove from set set = ac, s[4] = b will add into the set, set =abc
            //6th iteration c is present in the set, so remove set.Remove(s[left]), left = 2 , set = ab, s[5], set =abc
            //7th, set= bc, set = c, set=bc
            //8th set = b
            //9th set=''

            //bca
        }
    }
}
