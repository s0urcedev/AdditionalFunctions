﻿using System;

namespace Base
{
    class Program
    {

        public static int RomArab(string p)
        {
            int z = 0;
            try
            {
                for(int i = 0; i < p.Length; i ++)
                {
                    if(char.ToLower(p[i]) == 'i')
                    {
                        try
                        {
                            if(char.ToLower(p[i+1]) == 'v' || char.ToLower(p[i+1]) == 'x')
                            { 
                                z -= 1;
                            }
                            else
                            {
                                z += 1;
                            }
                        }
                        catch
                        {
                            z += 1;
                        }
                    }
                    else if(char.ToLower(p[i]) == 'v')
                    {
                        z += 5;
                    }
                    else if(char.ToLower(p[i]) == 'x')
                    {
                        try
                        {
                            if(char.ToLower(p[i+1]) == 'c' || char.ToLower(p[i+1]) == 'l')
                            {
                                z -= 10;
                            }
                            else
                            {
                                z += 10;
                            }
                        }
                        catch
                        {
                            z += 10;
                        }
                    }
                    else if(char.ToLower(p[i]) == 'l')
                    {
                        z += 50;
                    }
                    else if(char.ToLower(p[i]) == 'c')
                    {
                        try
                        {
                            if(char.ToLower(p[i+1]) == 'm' || char.ToLower(p[i+1]) == 'd')
                            { 
                                z -= 100;
                            }
                            else
                            {
                                z += 100;
                            }
                        }
                        catch
                        {
                            z += 100;
                        }
                    }
                    else if(char.ToLower(p[i]) == 'd')
                    {
                        z += 500;
                    }
                    else if(char.ToLower(p[i]) == 'm')
                    {
                        z += 1000;
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect input");
                        return 0;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Uncorrect input");
                return 0;
            }
            return z;
        }

        public static string ArabRom(int s)
        {
            string v = "";
            try
            {
                while(s > 0)
                {
                    if(s >= 1000)
                    {
                        s -= 1000;
                        v += "M";
                    }
                    else if(s >= 900)
                    {
                        s -= 900;
                        v += "CM";
                    }
                    else if(s >= 500)
                    {
                        s -= 500;
                        v += "D";
                    }
                    else if(s >= 400)
                    {
                        s -= 400;
                        v += "CD";
                    }
                    else if(s >= 100)
                    {
                        s -= 100;
                        v += "C";
                    }
                    else if(s >= 90)
                    {
                        s -= 90;
                        v += "XC";
                    }
                    else if(s >= 50)
                    {
                        s -= 50;
                        v += "L";
                    }
                    else if(s >= 40)
                    {
                        s -= 40;
                        v += "XL";
                    }
                    else if(s >= 10)
                    {
                        s -= 10;
                        v += "X";
                    }
                    else if(s >= 9)
                    {
                        s -= 9;
                        v += "IX";
                    }
                    else if(s >= 5)
                    {
                        s -= 5;
                        v += "V";
                    }
                    else if(s >= 4)
                    {
                        s -= 4;
                        v += "IV";
                    }
                    else if(s >= 1)
                    {
                        s -= 1;
                        v += "I";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Uncorrect input");
                return "";
            }
            return v;
        }

        public static void Main()
        {
            Console.ReadLine();
        }
    }
}