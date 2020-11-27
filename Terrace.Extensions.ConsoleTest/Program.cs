using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Terrace.Extensions.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x00, 0x02 };
            Console.WriteLine(bytes.ToInt16());
            Console.WriteLine(bytes.ToInt16(1));
            Console.WriteLine(bytes.ToInt16(2));

            string s = "22.3";
            Console.WriteLine(s.ToInt32OrDefault(1));
            
            Stopwatch sw = new Stopwatch();
            sw.Restart();
            for (int i = 0; i < 100000; i++)
                bytes.GetRange(1);
            sw.Stop();
            Console.WriteLine($"{sw.ElapsedTicks} ticks");
        }
    }
}
