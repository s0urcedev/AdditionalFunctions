using System;

namespace Base
{
    class Program
    {

        public static void PrintArray(List<int> a)
        {
            Console.Write("[ ");
            for(int i = 0; i < a.Count(); i ++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.Write("]");
        }

        public static void PrintArrayArray(List<List<int>> a)
        {
            Console.Write("[ ");
            for(int i = 0; i < a.Count(); i ++)
            {
                PrintArray(a[i]);
                Console.Write(" ");
            }
            Console.Write("]");
        }

        public static int Factorial(int n)
        {
            if(n == 0) return 1;
            else return n * Factorial(n - 1);
        }

        public static int CountCombinations(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        public static int CountPermutations(int n, int k)
        {
            return Factorial(n) / Factorial(n - k);
        }

        public static List<List <int>> GenerateCombinations(List<int> arr, int k)
        {
            List<List <int>> result = new List<List <int>>(){};
            for(int i = 0; i < CountCombinations(arr.Count(), k); i ++)
            {
                List<int> localResult = new List<int>(1){0};
                int n = arr.Count();
                int s = 0;
                for(int j = 1; j <= k; j ++)
                {
                    int t = localResult[j - 1] + 1;
                    while((t < (n - k + j)) && ((s + CountCombinations(n - t, k - j)) <= i))
                    {
                        s += CountCombinations(n - t, k - j);
                        t ++;
                    }
                    localResult.Add(t);
                }
                for(int l = 1; l < localResult.Count(); l ++){
                    localResult[l] = arr[localResult[l] - 1];
                }
                result.Add(localResult.GetRange(1, localResult.Count() - 1));
            }
            return result;
        }

        public static List<List <int>> GeneratePermutations(List<int> arr, int k)
        {
            List<List <int>> result = new List<List <int>>(){};
            List<List <int>> m = GenerateCombinations(arr, k);
            foreach(List <int> a in m)
            {
                List<List <int>> localResult = new List<List <int>>(){};
                for(int i = 0; i < Factorial(a.Count()); i ++)
                {
                    int ind = i + 1;
                    List <int> localLocalResult = new List <int>(){};
                    List <int> localLocalArr = new List <int>(){};
                    foreach(int r in a)
                    {
                        localLocalArr.Add(r);
                    }
                    int n = localLocalArr.Count();
                    for(int j = 1; j <= n; j ++)
                    {
                        int f = Factorial(n - j);
                        int g = (ind + f - 1) / f;
                        localLocalResult.Add(localLocalArr[g - 1]);
                        localLocalArr.RemoveAt(g - 1);
                        ind -= (g - 1) * f; 
                    }
                    if(localLocalArr.Count() > 0)
                    {
                        localLocalResult.Add(localLocalArr[0]);
                    }
                    localResult.Add(localLocalResult);
                }
                foreach(List <int> u in localResult)
                {
                    result.Add(u);
                }
            }
            return result;
        }

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}