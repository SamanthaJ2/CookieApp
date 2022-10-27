using System.Net.Http.Headers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("applicatoin/json"));

            client.DefaultRequestHeaders.Add("User-Agent", "Sam's API");

            var requestUri = "https://localhost.7256/Api/VideoGames";
        }
    }
}