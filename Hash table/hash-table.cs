using System;
using System.Collections.Generic;

namespace Base
{

    class HashTable<T>
    {

        private int _size;
        private T[] _table;

        private bool _IsPrime(int n)
        {
            List<int> result = new List<int>() { };
            int d = 2;
            while (d * d <= n)
            {
                if (n % d == 0)
                {
                    result.Add(d);
                    n = n / d;
                }
                else
                {
                    d++;
                }
            }
            if (n > 1)
            {
                result.Add(n);
            }
            if (result.Count > 1) return false;
            else return true;
        }

        private int _NearesPrime(int n)
        {
            if (n % 2 == 0)
            {
                n += 1;
            }
            while (!this._IsPrime(n))
            {
                n += 2;
            }
            return n;
        }

        private int _CountHash(string s)
        {
            int n = 7;
            foreach (char c in s)
            {
                n = n * 31 + (int)c;
            }
            return (int)(this._size * ((n * ((Math.Sqrt(5) - 1) / 2)) - Math.Floor(n * ((Math.Sqrt(5) - 1) / 2))));
        }

        public HashTable(int size)
        {
            this._size = this._NearesPrime(size);
            this._table = new T[this._size];
            for (int i = 0; i < this._size; i++)
            {
                this._table[i] = default(T);
            }
        }

        public T Search(string key)
        {
            return this._table[this._CountHash(key)];
        }

        public void Insert(string key, T value)
        {
            this._table[this._CountHash(key)] = value;
        }

        public void Remove(string key)
        {
            this._table[this._CountHash(key)] = default(T);
        }

    }

    class Program
    {

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}