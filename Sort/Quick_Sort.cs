using System;

namespace Base
{
    class Program
    {
        public static void Sort(ref int[] array, int b, int e)
        {
            int l = b;
            int r = e;
            int p = array[(l + r) / 2];
            while(l <= r)
            {
                while(array[l] < p)
                {
                    l ++;
                }
                while(array[r] > p)
                {
                    r --;
                }
                if(l <= r)
                {
                    if(l < r)
                    {
                        array[l] = array[l] + array[r];
                        array[r] = array[l] - array[r];
                        array[l] = array[l] - array[r];
                    }
                    l ++;
                    r --;
                }
            }
            if(b < r)
            {
                Sort(ref array, b, r);
            }
            if(e > l)
            {
                Sort(ref array, l, e);
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
            Sort(ref a, 0, a.Length - 1);
            foreach(int i in a)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}