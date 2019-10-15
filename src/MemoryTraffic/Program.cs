using System;
using System.Threading;

namespace MemoryTraffic
{
    class Program
    {
        private static int _total;

        static void Main()
        {
            while (true)
            {
                var buf = GenerateMemoryTraffic();
                _total += buf[0];

                Thread.Sleep(1);
            }
        }

        private static byte[] GenerateMemoryTraffic()
        {
            var mb = 1024 * 1024;
            var size = new Random().Next(mb, mb * 32);

            return new byte[size];
        }
    }
}
