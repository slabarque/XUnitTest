using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions.Equivalency;
using Xunit.Sdk;

namespace XUnitTest
{
    public class TestBase
    {
        protected Action<string> LogAction;
        private readonly int _minWaitTime;
        private readonly int _maxWaitTime;
        private readonly Random _random;

        public TestBase(Action<string> logAction, int minWaitTime=50, int maxWaitTime=1000)
        {
            LogAction = logAction;
            
            _minWaitTime = minWaitTime;
            _maxWaitTime = maxWaitTime;
            //LoggingClass.LogActions[Thread.CurrentThread.ManagedThreadId] = logAction;
            LoggingClass.LogAction.Value = logAction;
            _random = new Random(Convert.ToInt32(DateTime.Now.Ticks%Int32.MaxValue));
            //_helper = new LoggingClass();
        }

        protected void Log(string message)
        {
            LogAction(message);
        }

        protected async Task<bool> DoSomethingAsyncAndLogIt()
        {
            StackTrace stackTrace = new StackTrace();
            // Get calling method name
            var caller = stackTrace.GetFrame(5).GetMethod();
            var callername = caller.DeclaringType.Name + "." + caller.Name;

            //LoggingClass.LogAction = Log;

            //simulate something that does differs in execution time
            var wait = _random.Next(_minWaitTime, _maxWaitTime);
            Log($"Waiting {wait} ms {callername}");
            await Task.Delay(wait);
            Log($"{wait} ms has passed {callername}");

            //passing the log action like this seems to work
            //new LoggingClass(LoggingClass.LogAction).DoSomethingAndLog(new string(Enumerable.Repeat(0,wait).Select(i=>(char)(_random.Next(0,26) + (int)'a')).ToArray()));

            //but what if my only option is using a static log action? e.g. the logging class could be instantiated from an extension method, ...

            new LoggingClass().DoSomethingAndLog(callername + " : " + new string(Enumerable.Repeat(0,wait).Select(i=>(char)(_random.Next(0,26) + (int)'a')).ToArray()));

            return true;
        }
    }
}
