using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class Fibbonacci
    {
        //public static long  Fibonacci(int n)
        //{
        //    if(n <= 1)
        //        return 0;

        //    long previous = 0;
        //    long current = 1;
        //    for(int i=2;i <= n; i++)
        //    {
        //        long next = previous + current;
        //        previous=current;
        //        current=next;
        //    }
        //    return current;
        //}


        //public static bool ValidAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //        return false;
        //    int[] count = new int[26];

        //    foreach (char c in s)
        //        count[c - 'a']++;

        //    foreach(char c in t)
        //    {
        //        count[c - 'a']--;
        //        if (count[c - 'a']<0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //public static int RemoveDupFromSortedArray(int[] nums)
        //{
        //    if (nums.Length == 0)
        //        return 0;

        //    int k = 0;
        //    for(int i=1;i<nums.Length;i++)
        //    {
        //        if (nums[i] != nums[i-1])
        //        {
        //            nums[k]=nums[i];
        //            k++;
        //        }
        //    }
        //    return k;
        //}

        //public static string RevString(string s)
        //{
        //    int left = 0;
        //    int right = s.Length - 1;
        //    char[] str = s.ToCharArray();
        //    while(left < right)
        //    {
        //        char temp;
        //        temp=str[left];
        //        str[left]=str[right];
        //        str[right]=temp;

        //        left++;
        //        right--;
        //    }
        //    return new string(str);
        //}
        //public static bool IsPalindrome(string str)
        //{
        //    int left = 0;
        //    int right = str.Length - 1;
        //    while(left<right)
        //    {
        //        if (str[left] != str[right])
        //            return false;

        //        left++;
        //        right--;
        //    }
        //    return true;
        //}

        //public static int[] RotateArray(int[] nums, int k)
        //{
        //    int length = nums.Length;
        //    k =  k % length;
        //    Reverse(nums, 0, length-1); //rev whole array
        //    Reverse(nums, 0, k - 1); //Reverse 1st k elements
        //    Reverse(nums, k, length - 1); //Reverse remaining elements

        //    return nums;
        //}
        //static void Reverse(int[] nums, int left, int right)
        //{
        //    while (left < right)
        //    {
        //        int temp = nums[left];
        //        nums[left] = nums[right];
        //        nums[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}

        //public static bool IsPAlindrome(string str)
        //{
        //    char[] s =str.ToCharArray();
        //    int left = 0;
        //    int right = s.Length - 1;

        //    while(left < right)
        //    {
        //        if (s[left] != s[right])
        //            return false;

        //        left++;
        //        right--;
        //    }
        //    return true;
        //}

        //public static void MergeSort(int[] array)
        //{
        //    if (array == null || array.Length <= 1)
        //        return;

        //    MergeSortHelper(array, 0, array.Length - 1);


        //}
        //public static void MergeSortHelper(int[] array, int left, int right)
        //{
        //    if(left<right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        MergeSortHelper(array, left, mid);
        //        MergeSortHelper(array, mid + 1, right);
        //        Merge(array, left, mid, right);
        //    }
        //}
        //private static void Merge(int[] array, int left, int mid, int right)
        //{
        //    int n1 = mid - left + 1;
        //    int n2 = right - mid;

        //    int[] leftArray = new int[n1];
        //    int[] rightArray = new int[n2];

        //    Array.Copy(array, left, leftArray, 0, n1);
        //    Array.Copy(array, mid + 1, rightArray, 0, n2);

        //    int i = 0, j = 0, k = left;
        //    while (i < n1 && j < n2)
        //    {
        //        if (leftArray[i] <= rightArray[j])
        //        {
        //            array[k++] = leftArray[i++];
        //        }
        //        else
        //        {
        //            array[k++] = rightArray[j++];
        //        }
        //    }

        //    while (i < n1)
        //    {
        //        array[k++] = leftArray[i++];
        //    }

        //    while (j < n2)
        //    {
        //        array[k++] = rightArray[j++];
        //    }
        //}

        //public static int[] RemoveDupFromArray(int[] nums)
        //{
        //    HashSet<int> seen = new HashSet<int>();
        //    List<int> result = new List<int>();

        //    foreach(var item in nums)
        //    {
        //        if(seen.Add(item))
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result.ToArray();
        //}
        //public static bool IsValidAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //        return false;

        //    int[] count = new int[26];
        //    foreach (char c in s)
        //        count[c - 'a']++;

        //    foreach(char c in t)
        //    {
        //        count[c - 'a']--;
        //        if (count[c - 'a'] < 0)
        //            return false;
        //    }
        //    return true;
        //}

        //static int[] RotateArray(int[] nums, int k)
        //{
        //    int length = nums.Length;
        //    k = k % length;

        //    Reverse(nums, 0, length - 1);//REverse the whole array
        //    Reverse(nums, 0, k - 1);//Reverse 1st k element
        //    Reverse(nums, k, length - 1); // Reverse the rest elements

        //    return nums;
        //}
        //public static void Reverse(int[] nums, int left, int right)
        //{
        //    int temp;
        //    while (left < right)
        //    {
        //        temp = nums[left];
        //        nums[left] = nums[right];
        //        nums[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}

       public static int lonSunStringWithoutRepeat(string s)
       {
            HashSet<int> set = new HashSet<int>();
            int maxValue = 0;
            int left = 0;
            for(int right =0; right < s.Length;right++)
            {
                if (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(s[right]);
                maxValue = Math.Max(maxValue, right - left + 1);
            }
            return maxValue;
       }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
            }
        }
        public static bool DetectCycle(ListNode head )
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast!=null && fast.next!= null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                    return true;
            }
            return false;
        }
        public static void Main(string[] args)
        {
            //  Fibbonacci numbers
            //Fibonacci(8);
            //ValidAnagram("anagram", "nagaram");
            //int[] nums = { 3, 3, 6 };
            //RemoveDupFromSortedArray(nums);
            //RevString("wel");
            //IsPalindrome("madan");

            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;

            DetectCycle(node1);

        }
    }
}
