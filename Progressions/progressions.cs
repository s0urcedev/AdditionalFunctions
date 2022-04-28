using System;

namespace Base
{

    class ArithmeticProgression
    {
        private int _d = 0;
        private List<int> _a = new List<int>(){};
    
        public ArithmeticProgression(int start = 0, int d = 0)
        {
            _a.Add(start);
            _d = d;
        }

        public List<int> GetSequence()
        {
            return _a;
        }

        public int GetDifference()
        {
            return _d;
        }

        public void SetStartElement(int start)
        {
            _a.Clear();
            _a.Add(start);
        }

        public void SetDifference(int d)
        {
            int start = _a[0];
            _a.Clear();
            _a.Add(start);
            _d = d;
        }

        public int GetNth(int n)
        {
            return _a[0] + (n - 1) * _d;
        }

        public void CountToNth(int n)
        {
            for(int _ = _a.Count(); _ < n; _ ++)
            {
                _a.Add(_a[^1] + _d);
            }
        }

        public List<int> GetToNth(int n)
        {
            CountToNth(n);
            return _a;
        }

        public int GetSumToNth(int n)
        {
            return n * (_a[0] + GetNth(n)) / 2;
        }
    }

    class GeometricProgression
    {
        private int _r = 0;
        private List<int> _b = new List<int>(){};
    
        public GeometricProgression(int start = 1, int r = 1)
        {
            if(start == 0 || r == 0)
            {
                Console.WriteLine("start_element or ratio can't be 0");
                return;
            }
            _b.Add(start);
            _r = r;
        }

        public List<int> GetSequence()
        {
            return _b;
        }

        public int GetRatio()
        {
            return _r;
        }

        public void SetStartElement(int start)
        {
            if(start == 0)
            {
                Console.WriteLine("start_element can't be 0");
                return;
            }
            _b.Clear();
            _b.Add(start);
        }

        public void SetRatio(int r)
        {
            if(r == 0)
            {
                Console.WriteLine("ratio can't be 0");
                return;
            }
            int start = _b[0];
            _b.Clear();
            _b.Add(start);
            _r = r;
        }

        public int GetNth(int n)
        {
            return (int)(_b[0] * Math.Pow(_r, n - 1));
        }

        public void CountToNth(int n)
        {
            for(int _ = _b.Count(); _ < n; _ ++)
            {
                _b.Add(_b[^1] * _r);
            }
        }

        public List<int> GetToNth(int n)
        {
            CountToNth(n);
            return _b;
        }

        public int GetSumToNth(int n)
        {
            return (int)((_b[0] * (Math.Pow(_r, n) - 1)) / (_r - 1));
        }
    }

    class HarmonicProgression
    {
        private int _d = 0;
        private List<float> _c = new List<float>(){};
    
        public HarmonicProgression(float start = 1.0f, int d = 0)
        {
            _c.Add(start);
            _d = d;
        }

        public List<float> GetSequence()
        {
            return _c;
        }

        public int GetDifference()
        {
            return _d;
        }

        public void SetStartElement(int start)
        {
            _c.Clear();
            _c.Add(start);
        }

        public void SetDifference(int d)
        {
            float start = _c[0];
            _c.Clear();
            _c.Add(start);
            _d = d;
        }

        public float GetNth(int n)
        {
            return (float)Math.Pow((Math.Pow(_c[0], -1) + (n - 1) * _d), -1);
        }

        public void CountToNth(int n)
        {
            for(int _ = _c.Count(); _ < n; _ ++)
            {
                _c.Add((float)Math.Pow((Math.Pow(_c[^1], -1) + _d), -1));
            }
        }

        public List<float> GetToNth(int n)
        {
            CountToNth(n);
            return _c;
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