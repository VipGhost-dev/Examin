using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Examin
{
    internal class DebugTrace
    {
        public static void onStart()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("diagnostic.txt"));
        }
        public static void DebugWrite(string str)
        {
            Debug.WriteLine(str);
            Trace.Flush();
        }
    }
}
