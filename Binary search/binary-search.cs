using System;

namespace Base
{
    class Program
    {

        public static int BinarySearch(ref int[] arr, int value)
        {
            int first = 0;
            int last = arr.Length - 1;
            int middle;
            while(first <= last)
            {
                middle = Math.Floor((first + last) / 2);
                if(value < arr[middle])
                {
                    last = middle - 1;
                }
                else if(value > arr[middle])
                {
                    first = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}