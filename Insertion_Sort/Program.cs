using System;

namespace Insertion_Sort
{
    public class Program
    {
        static void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("After Insertion sort the string values are: ");
            Console.WriteLine("-------------------------------------------------------------");
            string[] names = { "Monday", "Tuesday", "Sunday", "Wednesday","Thrusday","Friday","Saturday" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
