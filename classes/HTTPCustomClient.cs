using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

public class HTTPCustomClient : IHTTPCustomClient
{
    HttpClient? client = new HttpClient();
    public async Task GetUserData(string? userName)
    {

        try
        {
            using HttpResponseMessage response = await client.GetAsync($"https://api.wiseoldman.net/v2/players/{userName}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonDocument.Parse(content);
            string? output = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(output);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public Task PostUserData(string? userName, string? userData)
    {
        throw new NotImplementedException();
    }
}