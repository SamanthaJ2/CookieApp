using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TestDELETE
    {
        private static readonly HttpClient client = new HttpClient();

        [Fact]
        public async void APIDelete()
        {
            var resultDELETE = await Program.ClientDELETE();

            Assert.Equal((double)204, (double)resultDELETE.StatusCode);
        }

    }
}
