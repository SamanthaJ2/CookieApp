using ConsoleApp2.Models;
using Newtonsoft.Json.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

public class Program
{


    static async Task Main(string[] args)
    {
        var msg = await ClientGET();
        Console.WriteLine(JToken.Parse(msg).ToString());

        var resultPOST = await ClientPOST();
        Console.WriteLine(resultPOST);

        var resultPUT = await ClientPUT();
        Console.WriteLine(resultPUT);

        var resultDELETE = await ClientDELETE();
        Console.WriteLine(resultDELETE);

    }

    public class Header : HttpClient
    {
        public string requestUri { get; set; }
        public HttpClient client { get; set; }

        public Header()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            client.DefaultRequestHeaders.Add("User-Agent", "Jim's API");

            requestUri = "https://localhost:7179/api/Cookies/";
        }
    }

    public static async Task<string> ClientGET()
    {

        Header client = new Header();
        var requestUri = client.requestUri;

        Console.WriteLine(requestUri);

        var stringTask = client.GetStringAsync(requestUri);
        var msg = await stringTask;

        return msg;

    }
    public static async Task<HttpResponseMessage> ClientPOST()
    {
        Header client = new Header();
        var requestUri = client.requestUri;

        var cookiePOST = new Cookie { Name = "Chocolate Chip", Flavor = "Chocolate", Quantity = 1 };
 
        var resultPOST = await client.PostAsync<Cookie>(requestUri, cookiePOST, new JsonMediaTypeFormatter());

        return (HttpResponseMessage)resultPOST;

    }
    public static async Task<HttpResponseMessage> ClientPUT()
    {
        Header client = new Header();
        var requestUri = client.requestUri;

        var cookiePUT = new Cookie {Id = 2, Name = "Sugar Cookie", Flavor = "", Quantity = 1 };
        var resultPUT = await client.PutAsync<Cookie>(requestUri + "2", cookiePUT, new JsonMediaTypeFormatter());

        return (HttpResponseMessage)resultPUT;

    }

    public static async Task<HttpResponseMessage> ClientDELETE()
    {
        Header client = new Header();
        var requestUri = client.requestUri;

        var resultDELETE = await client.DeleteAsync(requestUri + "1008");

        return (HttpResponseMessage)resultDELETE;

    }
}
