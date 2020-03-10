using System;
using System.Collections.Generic;
using System.Text;

namespace Resurection
{
    public class Sender 
    {
        public void AnalyzeData(IDataRes dataAdapter)
        {
            dataAdapter.Send("Data to analyze.");
        }
    }
}
