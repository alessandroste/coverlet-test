using CoverageTest.Service;
using System.Threading.Tasks;
using Xunit;

namespace CoverageTest
{
    public class MyServiceTests
    {
        [Fact]
        public async Task TestAsyncStd()
        {
            var service472 = new ServiceNet472();
            await service472.WorkAsync();
            await service472.WorkAsync2();
            var serviceStd = new ServiceNetStd();
            await serviceStd.WorkAsync();
            await serviceStd.WorkAsync2();
        }
    }
}
