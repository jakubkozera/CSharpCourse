using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
#pragma warning disable 162

namespace AsyncAwait
{
    public class TaskException
    {
        public async Task ThrowException()
        {
            Debug.WriteLine("2");

            throw new Exception("error");
        }

        [Test]
        public async Task Test1()
        {
            var exceptionHandled = false;
            Debug.WriteLine("1");

            var task = ThrowException();

            try
            {
                
                Debug.WriteLine("3");
                await task;
                Debug.WriteLine("4");
            }
            catch
            {
                exceptionHandled = true;
            }


            Assert.True(exceptionHandled);
        }
    }
}
