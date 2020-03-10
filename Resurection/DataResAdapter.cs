using System;
using System.Collections.Generic;
using System.Text;

namespace Resurection
{
    public class DataResAdapter : IDataRes
    {
        public DataAnalyzer DataAnalyzer { get; set; } = new DataAnalyzer();

        public void Send(string data)
        {
            var dataToAnalyze = new Data() { Info = data };
            DataAnalyzer.Analyzer(dataToAnalyze);
            Console.WriteLine("Using Analyzer throw adapter by Sender.");
        }
    }
}
