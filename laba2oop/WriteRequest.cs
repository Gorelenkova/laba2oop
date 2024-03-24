using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2oop
{
      class WriteRequest
    {
        public async Task WriteAsyncRequest()
        {

            GetAsyncRequestServer request1 = new GetAsyncRequestServer();
            GetAsyncRequestServer request2 = new GetAsyncRequestServer();
            GetAsyncRequestServer request3 = new GetAsyncRequestServer();

            request1.SetUri();
            request2.SetUri();
            request3.SetUri();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var tasks = new List<Task> { request1.Get(), request2.Get(), request3.Get() };
            await Task.WhenAll(tasks);
            stopwatch.Stop();
            Console.WriteLine("Общее время выполнения запросов: " + stopwatch.Elapsed);
        }
        public void WriteSyncRequest()
        {
          
            GetRequestServer request1 = new GetRequestServer();
            GetRequestServer request2 = new GetRequestServer();
            GetRequestServer request3 = new GetRequestServer();
            Stopwatch stopwatch = new Stopwatch();

            request1.SetUri();
            request2.SetUri();
            request3.SetUri();

            stopwatch.Start();
            request1.Get();
            request2.Get();
            request3.Get();

            stopwatch.Stop();
            Console.WriteLine("Общее время выполнения запросов: " + stopwatch.Elapsed);
        }

    }
}
