using RestSharp;

using System.Threading.Tasks;
namespace desktop_bg
{
    public class ImageEntry
    {

    }
    public class ImageGenerator
    {
        async public static Task<byte[]?> GenerateImage()
        {
            var endpoint = "https://api.pexels.com/v1/collections/featured";
            var client = new RestSharp.RestClient();
            var request = new RestRequest(endpoint);
            request.AddHeader("Authorization", "MatvM1gSI6BmlT1nKTQ5LPKVHepwe8HdvQE1fnzOMfgnc7ZH661iplMo");
            var result = await client.GetAsync<string>(request);


            return null;
        }

    }
}