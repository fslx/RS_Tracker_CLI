public interface IHTTPCustomClient
{
    /// <summary>
    /// Send a HTTP GET request to a external RestAPI
    /// </summary>
    /// <param name="userName">Oldschool RuneScape username to pass along to WiseOldMan</param>
    /// <returns>Awaitable task</returns>
    Task GetUserData(string? userName);
    /// <summary>
    /// Send a HTTP POST request to a external RestAPI
    /// </summary>
    /// <param name="userName">Oldschool RuneScape username to pass along to WiseOldMan</param>
    /// <param name="userData">POST-request body</param>
    /// <returns>Awaitable task</returns>
    Task PostUserData(string? userName, string? userData);
}