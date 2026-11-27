using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
class Program1
{
    public static string RevString(string str)
    {
        int left = 0;
        char[] s = str.ToCharArray();
        int right = s.Length - 1;

        while(left < right)
        {
            char temp = s[left];
            s[left]=s[right];
            s[right]=temp;

            left++;
            right--;
        }
        return new string(s);
    }
    
    public static void Main(string[] args)
    {
        string s = "pwwkew";
        int[] arr = { 2, 3, 1, 2, 4, 3 };
        string s1 = "madan";


        RevString(s1);
        Console.ReadLine();
        //0+1 =1
        //1+1=2
        //1+2=3
        //2+3=5
        //3+5=8
        //5+8=13
        //8+13=21

        //IsPalin(s3);
    }
}