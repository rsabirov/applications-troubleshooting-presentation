using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace DeadLock
{
    internal class Program
    {
        private static object syncObject1 = new object();
        private static object syncObject2 = new object();
        private static int counter = 0;
        
        public static void Main(string[] args)
        {
            new Thread(o =>
            {
                while (true)
                {
                    lock (syncObject1)
                    {
                        lock (syncObject2)
                        {
                            counter++;
                        }
                    }
                }
            }).Start();


            for (int i = 0; i < 10000; i++)
            {
                lock (syncObject2)
                {
                    lock (syncObject1)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine("Hello world");
        }
    }
}