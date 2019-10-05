using Charset;
using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Alpha test = new Alpha();
            string s = null;
            foreach (var item in test.MixAlphaList("mixalpha-numeric-all-space"))
            {
                s += item;                
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
