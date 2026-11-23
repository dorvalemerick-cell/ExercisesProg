using System;

namespace ReverseAString
{
    /// Description: How to reverse a string
    internal class Program
    {
        public static void Main(string[] arhs)
        {
            string reverse = ReverseString("Emerick");
            Console.WriteLine(reverse);

        }
        public static string ReverseString(string s)
        {
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            s = new string(cArray);

            return s;
        }
    }
}
