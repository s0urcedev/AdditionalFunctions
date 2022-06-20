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
            for(int i = 0; i < a.Length; i ++)
            {
                int imin = i;
                for(int j = i + 1; j < a.Length; j ++)
                {
                    if(a[j] < a[imin])
                    {
                        imin = j;
                    }
                }
                if(imin != i)
                {
                    a[i] = a[i] + a[imin];
                    a[imin] = a[i] - a[imin];
                    a[i] = a[i] - a[imin];
                }
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