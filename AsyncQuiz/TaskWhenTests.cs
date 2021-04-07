using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AsyncAwait
{
    public class TaskWhenTests
    {
        public async Task<string> ReturnFoo()
        {
            await Task.Delay(3000);

            return "foo";
        }
        public async Task<string> ReturnFooFoo()
        {
            await Task.Delay(4000);

            return "foofoo";
        }


        [Test]
        public async Task Test1()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            await ReturnFoo();
            await ReturnFooFoo();

            stopWatch.Stop();
            var milliseconds = stopWatch.ElapsedMilliseconds;

            var underFiveSeconds = milliseconds < 5000;

            Assert.True(underFiveSeconds);
        }


        [Test]
        public async Task Test2()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            await Task.WhenAll(ReturnFoo(), ReturnFooFoo());

            stopWatch.Stop();
            var milliseconds = stopWatch.ElapsedMilliseconds;

            var underFiveSeconds = milliseconds < 5000;

            Assert.True(underFiveSeconds);
        }
    }
}
