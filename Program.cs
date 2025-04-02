namespace RS_Tracker_CLI;

class Program
{
    static async Task Main(string[] args)
    {
        CLI cli = new CLI();
        await cli.RunCLI();
    }
}
