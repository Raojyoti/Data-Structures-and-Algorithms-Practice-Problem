using System;

namespace Anagram_Detection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.Write("Enter first string: ");
            s1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            s2 = Console.ReadLine();
            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);
            string res1 = new string(a1);
            string res2 = new string(a2);
            if (res1 == res2) Console.WriteLine("Strings are anagram.");
            else Console.WriteLine("Strings are not anagram.");
            Console.WriteLine("\n");
        }
    }
}
