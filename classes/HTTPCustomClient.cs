using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using Spectre.Console;
using Spectre.Console.Json;

public class HTTPCustomClient : IHTTPCustomClient
{
    HttpClient client = new HttpClient();
    FileHandler fileHandler = new FileHandler();
    public async Task GetUserData(string? userName)
    {

        try
        {
            using HttpResponseMessage response = await client.GetAsync($"https://api.wiseoldman.net/v2/players/{userName}");
            // tesing another endpoint for different games
            //using HttpResponseMessage response = await client.GetAsync($"https://wank.wavu.wiki/api/replays");

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var data = JsonDocument.Parse(content);
            string? output = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            fileHandler.UpdateFileData("rs_data.json", output);
            var json = new JsonText(content);

            AnsiConsole.Write(new Panel(json)
                    .Header("Wise Old Man Data")
                    .Collapse()
                    .RoundedBorder()
                    .BorderColor(Color.Yellow));
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