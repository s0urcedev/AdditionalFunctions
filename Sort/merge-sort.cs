using System;

namespace Base
{
    class Program
    {
        public static void Sort(ref int[] array, int m)
        {
            int[] mass = new int[m];
            for(int i = 0; i < m; i ++)
            {
                mass[i] = array[i];
            }
            if(m <= 1)
            {
                array[0] = mass[0];
            }
            else
            {
                int[] L = new int[m / 2];
                int[] R = new int[m - (m / 2)];
                for(int i = 0; i < m; i ++)
                {
                    if(i < m / 2) L[i] = mass[i];
                    else R[i - (m / 2)] = mass[i];
                }
                Sort(ref L, m / 2);
                Sort(ref R, m - (m / 2));
                int h = 0, f = 0, k = 0;
                int[] C = new int[m];
                while(h < m / 2 && f < m - (m / 2))
                {
                    if(L[h] < R[f]){
                        C[k] = L[h];
                        h ++;
                    }
                    else{
                        C[k] = R[f];
                        f ++;
                    }
                    k ++;
                }
                while(h < m / 2)
                {
                    C[k] = L[h];
                    h ++;
                    k ++;
                }
                while(f < m - (m / 2))
                {
                    C[k] = R[f];
                    f ++;
                    k ++;
                }
                for(int i = 0; i < m; i ++)
                {
                    array[i] = C[i];
                }
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