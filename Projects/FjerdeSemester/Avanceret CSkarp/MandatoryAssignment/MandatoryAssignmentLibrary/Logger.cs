using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary
{
    public class Logger
    {
        public TraceSource ts;

        public Logger(string nameOfLog)
        {
            this.ts = new TraceSource(nameOfLog);
            InitializeTrace(nameOfLog);
        }

        public void InitializeTrace(string nameOfLog)
        { 
            ts.Switch = new SourceSwitch(nameOfLog, "All");
            TraceListener tl = new ConsoleTraceListener();
            ts.Listeners.Add(tl);
        }

        public void LogInfo(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ts.TraceEvent(TraceEventType.Information, 1, msg);
        }
        public void LogWarning(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ts.TraceEvent(TraceEventType.Warning, 1, msg);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void LogError(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            ts.TraceEvent(TraceEventType.Error, 1, msg);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void LogFatal(string msg)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            ts.TraceEvent(TraceEventType.Critical, 1, msg);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
