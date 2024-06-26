﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmentLibrary
{
    public class Logger
    {
        TraceSource ts;
        private static Logger _logger;
        public static Logger GetLogger(string name = null)
        {
            return _logger ?? new Logger(name ?? "Logger");
        }
        private Logger(string name)
        {
            ts =  new TraceSource(name);
            InitializeTrace(name);
        }

        public void InitializeTrace(string name)
        {
            ts.Switch = new SourceSwitch(name, "All");
            TraceListener tl = new ConsoleTraceListener();
            ts.Listeners.Add(tl);
        }

        public void LogInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            ts.TraceEvent(TraceEventType.Information, 1, msg);
        }

        public void LogWarning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            ts.TraceEvent(TraceEventType.Warning, 1, msg);
            ResetConsole();

        }

        public void LogError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            ts.TraceEvent(TraceEventType.Error, 1, msg);
            ResetConsole();
        }

        public void LogFatal(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            ts.TraceEvent(TraceEventType.Critical, 1, msg);
            ResetConsole();
        }

        public void ResetConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void CloseLogger()
        {
            ts.Close();
        }
    }
}
