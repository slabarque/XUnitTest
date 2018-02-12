using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public class LoggingClass
    {
        public static Action<string> StaticLogAction;

        private readonly Action<string> _logAction;
        public LoggingClass(Action<string> injectedLogAction = null)
        {
            Action<string> notNullLogaction = injectedLogAction ?? StaticLogAction ?? (Action<string>)(message => Trace.WriteLine(message));
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
