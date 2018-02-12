using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace XUnitTest
{
    public class EvenMoreOtherNormalTests : TestBase
    {
        public EvenMoreOtherNormalTests(ITestOutputHelper output) : base(output.WriteLine)
        {
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