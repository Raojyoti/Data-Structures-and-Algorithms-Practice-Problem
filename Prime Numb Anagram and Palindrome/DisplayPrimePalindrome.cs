using System;
using System.Collections.Generic;
using System.Text;

namespace Prime_Numb_Anagram_and_Palindrome
{
    public class DisplayPrimePalindrome
    {
        public void DisplayPrimePalindromeNumber()
        {

            int count = 0;

            for (int i = 2; i <= 1000; i++)
            {

                int num = i, revNum = 0;
                while (num != 0)
                {
                    int digit = num % 10;
                    num /= 10;
                    revNum = revNum * 10 + digit;
                }


                if (revNum == i)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {

                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i + " ");
                        count++;
                        if (count == 10)
                        {
                            count = 0;
                        }
                    }
                }
            }
        }
    }
}
