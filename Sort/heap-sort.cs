using System;

namespace Base
{
    class Program
    {
        public static void Heapify(ref int[] array, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if(l < n && array[i] < array[l])
            {
                largest = l;
            }
            if(r < n && array[largest] < array[r])
            {
                largest = r;
            }
            if(largest != i)
            {
                array[i] = array[i] + array[largest];
                array[largest] = array[i] - array[largest];
                array[i] = array[i] - array[largest];
                Heapify(ref array, n, largest);
            }
        }

        public static void Sort(ref int[] array)
        {
            for(int i = array.Length / 2; i > -1; i --)
            {
                Heapify(ref array, array.Length, i);
            }
            for(int j = array.Length - 1; j > 0; j --)
            {
                array[j] = array[j] + array[0];
                array[0] = array[j] - array[0];
                array[j] = array[j] - array[0];
                Heapify(ref array, j, 0);
            }
        }

        public static void Main()
        {
            string[] w = Console.ReadLine().Split(" ");
            int[] a = new int[w.Length];
            for(int i = 0; i < w.Length; i ++)
            {
                a[i] = Convert.ToInt32(w[i]);
            }
            Sort(ref a, a.Length);
            foreach(int i in a)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}