using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XUnitTest
{
    public class LoggingClass
    {
        //public static ConcurrentDictionary<int, Action<string>> LogActions = new ConcurrentDictionary<int, Action<string>>();
        //[ThreadStatic]
        //public static Action<string> LogAction;

        public static AsyncLocal<Action<string>> LogAction = new AsyncLocal<Action<string>>();

        private readonly Action<string> _logAction;
        public LoggingClass(Action<string> injectedLogAction = null)
        {
            Action<string> notNullLogaction = injectedLogAction ?? /*LogActions[Thread.CurrentThread.ManagedThreadId]*/ LogAction.Value ?? (Action<string>)(message => Trace.WriteLine(message));
            _logAction = message => notNullLogaction($"{DateTime.Now.ToString().PadRight(15)}: {message}");
        }

        public void DoSomethingAndLog(string message)
        {
            //do something
            //blablabla
            //log it
            _logAction($"Logging from LoggingClass: {message}");
        }
    }
}
