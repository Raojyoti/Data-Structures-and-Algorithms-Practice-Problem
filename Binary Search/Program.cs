using System;

namespace Binary_Search
{
    internal class Program
    {
        static int BinarySearch(String[] arr, String word)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int res = word.CompareTo(arr[mid]);
                if (res == 0)
                    return mid;
                if (res > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            String[] arr = { "Happy", "Good", "Smile", "Always" };
            Console.WriteLine("Enter the word that are want to search: ");
            Console.WriteLine("-------------------------------------------------");
            String x = Console.ReadLine();
            int result = BinarySearch(arr, x);
            Console.Write("\n ");
            if (result == -1) 
            { 
                Console.WriteLine("Word not present");
            }
            else 
            { 
                Console.WriteLine("Word found at index " + result);
            }

            Console.Write("\n ");
            Console.WriteLine("Presented words are : ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(arr[0] + "," + "  " + arr[1] + "," + "  " + arr[2] + "," + "  " + arr[3]);
        }
    }
}
