using System;

namespace Base
{

    class Program
    {

        public static string AdditionBigNumbers(string a, string b)
        {
            while(b.Length < a.Length)
            {
                b = "0" + b;
            }
            while(a.Length < b.Length)
            {
                a = "0" + a;
            }
            string result = "";
            int c = 0;
            for(int i = a.Length - 1; i >= 0; i --)
            {
                int localResult = (a[i] - 48) + (b[i] - 48) + c;
                c = 0;
                if(localResult > 9)
                {
                    localResult -= 10;
                    c = 1;
                }
                result += localResult.ToString();
            }
            if(c == 1){
                result += "1";
            }
            string fresult = "";
            foreach(char s in result)
            {
                fresult = s + fresult;
            }
            return fresult;
        }

        public static string SubtractionBigNumbers(string a, string b)
        {
            bool k = false;
            if(Convert.ToInt32(a) < Convert.ToInt32(b))
            {
                string swap = a;
                a = b;
                b = swap;
                k = true;
            }
            while(b.Length < a.Length)
            {
                b = "0" + b;
            }
            while(a.Length < b.Length)
            {
                a = "0" + a;
            }
            string result = "";
            int c = 0;
            for(int i = a.Length - 1; i >= 0; i --)
            {
                int localResult = (a[i] - 48) - (b[i] - 48) - c;
                c = 0;
                if(localResult < 0)
                {
                    localResult += 10;
                    c = 1;
                }
                result += localResult.ToString();
            }
            if(c == 1)
            {
                result += "1";
            }
            while(result[result.Length - 1] == '0')
            {
                result = result.Substring(0, result.Length - 1);
            }
            string fresult = "";
            foreach(char s in result)
            {
                fresult = s + fresult;
            }
            if(k)
            {
                fresult = '-' + fresult;
            }
            return fresult; 
        }

        public static string MultiplicationBigNumbers(string a, string b)
        {
            string result = "";
            int c = 0;
            for(int i = b.Length - 1; i >= 0; i --)
            {
                string localResult = "";
                c = 0;
                for(int j = a.Length - 1; j >= 0; j --)
                {
                    int localLocalResult = (a[j] - 48) * (b[i] - 48) + c;
                    c = 0;
                    while(localLocalResult > 9)
                    {
                        localLocalResult -= 10;
                        c += 1;
                    }
                    localResult += localLocalResult.ToString();
                }
                if(c > 0)
                {
                    localResult += c.ToString();
                    c = 0;
                }
                string flocalResult = "";
                foreach(char s in localResult)
                {
                    flocalResult = s + flocalResult;
                }
                for(int f = 0; f < b.Length - i - 1; f ++)
                {
                    flocalResult += "0";
                }
                result = AdditionBigNumbers(result, flocalResult);
            }
            return result;
        }

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}