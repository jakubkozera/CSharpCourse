using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using NUnit.Framework;
#pragma warning disable 4014

namespace AsyncAwait
{
    public class TaskDelay
    {
        public async Task Delay1000()
        {
            Debug.WriteLine("4");
            await Task.Delay(1000);
            Debug.WriteLine("5");
        }

        public async Task Delay2000()
        {
            Debug.WriteLine("2");
            await Task.Delay(2000);
            Debug.WriteLine("3");
        }


        [Test]
        public async Task Test1()
        {
            Debug.WriteLine("1");

            await Delay2000();

            await Delay1000();

            Debug.WriteLine("6");


            Assert.Pass();
        }


        [Test]
        public async Task Test2()
        {
            Debug.WriteLine("1");

            Delay2000();

            Delay1000();

            Debug.WriteLine("6");
            
            Assert.Pass();
        }
    }


}