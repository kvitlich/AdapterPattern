using System;

namespace Resurection
{
    class Program
    {
        static void Main(string[] args)
        {
            Sender sender = new Sender();
            sender.AnalyzeData(new DataResAdapter());
            Console.ReadKey();
        }
    }
}
