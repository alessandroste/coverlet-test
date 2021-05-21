using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoverageTest.Service
{
    public class ServiceNetStd
    {
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);

        public async Task<string> WorkAsync()
        {
            await this.semaphore.WaitAsync();
            return "done";
        }

        public async Task<string> WorkAsync2()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1));
            return "done";
        }
    }
}
