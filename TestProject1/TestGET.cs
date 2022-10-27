using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestGET
    {
        private static readonly HttpClient client = new HttpClient();

        [Fact]
        public async void API_Get()
        {
            var msg = await Program.ClientGET();

            Assert.NotNull(msg);
        }

    }
}
