using System;
using T = System.Int32; // choose your function type 
using TArg = System.Int32; // choose your arguments type

namespace Base
{
    
    class Test
    {
        private Func<TArg, T> _func = null;
        private List<TArg> _params = new List<TArg>(){};
        private List<T> _results = new List<T>(){}; 
    
        public void SetFunc(Func<TArg, T> func)
        {
            _func = func;
        }

        public string GetFunc()
        {
            return _func.Method.ToString();
        }

        public bool TestCase(Func<TArg, T> func, TArg param, T result)
        {
            return func(param) == result;
        }

        public bool TestCase(TArg param, T result)
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return false;
            }
            return _func(param) == result;
        }

        public void AddTestCase(TArg param, T result)
        {
            _params.Add(param);
            _results.Add(result);
        }

        public void ShowTestCases()
        {
            if(_params.Count() == 0)
            {
                Console.WriteLine("No test cases");
            }
            for(int i = 0; i < _params.Count(); i ++)
            {
                Console.Write("Arguments: ");
                Console.Write(_params[i]);
                Console.Write(", Correct result: ");
                Console.Write(_results[i]);
                Console.Write("\n");
            }
        }

        public void ClearTestCases()
        {
            _params.Clear();
            _results.Clear();
        }

        public bool TestAll()
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return false;
            }
            for(int i = 0; i < _params.Count(); i ++)
            {
                if(_func(_params[i]) != _results[i])
                {
                    return false;
                }
            }
            return true;
        }

        public List<(TArg param, T result)> FindValid()
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return new List<(TArg param, T result)>(){};
            }
            List<(TArg param, T result)> result = new List<(TArg param, T result)>(){};
            for(int i = 0; i < _params.Count(); i ++)
            {
                try{
                    if(_func(_params[i]) == _results[i])
                    {
                        result.Add((_params[i], _results[i]));
                    }
                }
                catch{};
            }
            return result;
        }

        public List<(TArg param, T result)> FindInvalid()
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return new List<(TArg param, T result)>(){};
            }
            List<(TArg param, T result)> result = new List<(TArg param, T result)>(){};
            for(int i = 0; i < _params.Count(); i ++)
            {
                try{
                    if(_func(_params[i]) != _results[i])
                    {
                        result.Add((_params[i], _results[i]));
                    }
                }
                catch{};
            }
            return result;
        }
    
        public List<(TArg param, T result)> FindFailed()
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return new List<(TArg param, T result)>(){};
            }
            List<(TArg param, T result)> result = new List<(TArg param, T result)>(){};
            for(int i = 0; i < _params.Count(); i ++)
            {
                try{
                    _func(_params[i]);
                }
                catch
                {
                    result.Add((_params[i], _results[i]));
                };
            }
            return result;
        }

        public void PrintResults()
        {
            if(_func == null)
            {
                Console.WriteLine("No function set");
                return;
            }
            Console.Write("Function: ");
            Console.Write(_func.Method);
            Console.Write("\n");
            int totalyValid = 0;
            int totalyInvalid = 0;
            int totalyFailed = 0;
            for(int i = 0; i < _params.Count(); i ++)
            {
                Console.Write("Arguments: ");
                Console.Write(_params[i]);
                Console.Write(", Correct result: ");
                Console.Write(_results[i]);
                Console.Write(", Desicion: ");
                try
                {
                    if(_func(_params[i]) != _results[i])
                    {
                        Console.Write("INVALID");
                        Console.Write("\n");
                        totalyInvalid ++;
                    }
                    else
                    {
                        Console.Write("VALID");
                        Console.Write("\n");
                        totalyValid ++;
                    }
                }
                catch(Exception err)
                {
                    Console.Write("FAILED ( ");
                    Console.Write(err.Message);
                    Console.Write(" ) \n");
                    totalyFailed ++;
                }
            }
            Console.Write("Totaly: ");
            Console.Write(totalyValid);
            Console.Write(" VALID, ");
            Console.Write(totalyInvalid);
            Console.Write(" INVALID, ");
            Console.Write(totalyFailed);
            Console.Write(" FAILED\n");
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