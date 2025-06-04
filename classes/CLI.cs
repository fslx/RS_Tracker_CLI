public class CLI
{
    HTTPCustomClient clientClass = new HTTPCustomClient();
    private readonly FileHandler fileHandler = new FileHandler();
    public async Task RunCLI()
    {
        Console.WriteLine("Welcome to the RS_Tracker_CLI\nThis program utilizes the WiseOldMan API to gather information on OldSchool RuneScape Data.\nUsage: f: Fetch data on a OSRS RNS.  u: Send a POST-request back to OldWiseMan. q: Quit the program.");
        string? rl = Console.ReadLine();
        switch (rl?.ToLower())
        {
            case "f":
                Console.WriteLine("Enter RNS:");
                string? rsn = Console.ReadLine();
                fileHandler.GetRSN(rsn!);
                await clientClass.GetUserData(rsn);
                break;
            case "u":
                break;
            case "q":
                Environment.Exit(0);
                break;
            default:
                throw new ArgumentException("Invalid argument selected! Exiting...");
        }
    }
}