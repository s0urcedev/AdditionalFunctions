using System;

namespace Base
{
    class Program
    {
        public static void Main()
        {
            string[] w = Console.ReadLine().Split(" ");
            int[] a = new int[w.Length];
            for(int i = 0; i < w.Length; i ++)
            {
                a[i] = Convert.ToInt32(w[i]);
            }
            for(int j = 0; j < a.Length; j ++)
            {
                int key = a[j];
                int i = j - 1;
                while (i >= 0 && a[i] > key)
                {
                    a[i+1] = a[i];
                    i --;
                }
                a[i+1] = key;
            }
            foreach(int i in a)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}