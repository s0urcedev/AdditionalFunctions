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
            int k = 0;
            while(k < a.Length - 1)
            {
                k = 0;
                for(int j = 0; j < a.Length - 1; j ++)
                {
                    if(a[j] > a[j + 1])
                    {
                        a[j] = a[j] + a[j+1];
                        a[j+1] = a[j] - a[j+1];
                        a[j] = a[j] - a[j+1];
                    }
                    else
                    {
                        k ++;
                    }
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