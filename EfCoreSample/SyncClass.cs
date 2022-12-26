using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSample
{
    internal class SyncClass
    {
        public byte[] f1()
        {
            var task = File.ReadAllBytesAsync("path");
            task.Wait();

            return task.Result;
        }

        async Task<byte[]> AsyncTask()
        {
            return await Task.FromResult(File.ReadAllBytes("path"));
        }
    }
}
