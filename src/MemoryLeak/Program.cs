using System.Collections.Generic;
using System.Threading;

namespace MemoryLeak
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<byte[]>();
            while (true)
            {
                list.Add(new byte[1024 * 1024]);
                Thread.Sleep(1000);
            }
        }
    }
}