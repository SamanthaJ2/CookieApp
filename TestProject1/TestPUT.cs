using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestPUT
    {
        private static readonly HttpClient client = new HttpClient();

        [Fact]
        public async void APIPut()
        {
            var resultPUT = await Program.ClientPUT();

            Assert.Equal(204, (double)resultPUT.StatusCode);
        }

    }
}
