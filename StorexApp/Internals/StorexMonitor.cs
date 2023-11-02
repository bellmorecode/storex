using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorexApp.Internals
{
    public sealed class StorexMonitor
    {
        public static void Attach(EventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("e");
            }

            Trace.AutoFlush = true;
            Trace.Listeners.Add(new TextWriterTraceListener(@"c:\temp\storex.log"));

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Trace.TraceError($"Unhandled Exception: {e.ExceptionObject}");
        }
    }
}
