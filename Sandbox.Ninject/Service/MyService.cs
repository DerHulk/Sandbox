using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sandbox.Ninject.Service
{
    public class MyService : IDisposable, IMyService
    {
        private byte[] SomeData = new byte[1024 * 80];

        public void DoNothing()
        {
            System.Diagnostics.Debug.Write("I do nothing.");
        }

        public void Dispose()
        {
            System.Diagnostics.Debug.Write("Dispose");
        }
    }
}