using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions.Equivalency;

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
            LoggingClass.StaticLogAction = logAction;
            _random = new Random();
            //_helper = new LoggingClass();
        }

        protected void Log(string message)
        {
            LogAction(message);
        }

        protected async Task<bool> DoSomethingAsyncAndLogIt()
        {
            //simulate something that does differs in execution time
            var wait = _random.Next(_minWaitTime, _maxWaitTime);
            await Task.Delay(wait);
            Log($"{wait} ms has passed");

            //passing the log action like this seems to work
            //new LoggingClass(Log).DoSomethingAndLog(new string(Enumerable.Repeat(0,wait).Select(i=>(char)(_random.Next(0,26) + (int)'a')).ToArray()));

            //but what if my only option is using a static log action? e.g. the logging class could be instantiated from an extension method, ...
            new LoggingClass().DoSomethingAndLog(new string(Enumerable.Repeat(0,wait).Select(i=>(char)(_random.Next(0,26) + (int)'a')).ToArray()));

            return true;
        }
    }
}
