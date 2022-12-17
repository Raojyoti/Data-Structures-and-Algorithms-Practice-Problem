using System;

namespace Prime_Numb_Anagram_and_Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers that are Palindrome: ");
            DisplayPrimePalindrome obj=new DisplayPrimePalindrome();
            obj.DisplayPrimePalindromeNumber();
        }
    }
}
