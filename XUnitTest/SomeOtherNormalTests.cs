using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTest
{
    public class SomeOtherNormalTests : TestBase
    {
        public SomeOtherNormalTests(ITestOutputHelper output) : base(m =>
        {
            try
            {
                output.WriteLine($"[{output.GetHashCode()}][{Thread.CurrentThread.ManagedThreadId}]: {m}");
                Trace.WriteLine($"[{output.GetHashCode()}][{Thread.CurrentThread.ManagedThreadId}]: {m}");
            }
            catch (Exception e)
            {
                Trace.WriteLine($"Could not write to ouput helper: [{output.GetHashCode()}][{Thread.CurrentThread.ManagedThreadId}]. Message: {m}. Exception {e}.");
                throw;
            }
        })
        {
            output.WriteLine($"[{output.GetHashCode()}][{Thread.CurrentThread.ManagedThreadId}]: Start new test");
        }

        [Fact]
        public async Task Test()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test1()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test2()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test3()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test4()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test5()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test6()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test7()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test8()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test9()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test10()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test11()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test12()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }

        [Fact]
        public async Task Test13()
        {
            bool result = await DoSomethingAsyncAndLogIt();

            result.Should().BeTrue();
        }
    }
}