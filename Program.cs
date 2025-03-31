namespace RS_Tracker_CLI;

class Program
{
    static async Task Main(string[] args)
    {
        HTTPCustomClient clientClass = new HTTPCustomClient();
        await clientClass.GetUserData("your_rns");
    }
}
