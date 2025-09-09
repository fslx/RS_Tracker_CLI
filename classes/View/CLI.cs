using Spectre.Console;
public class CLI
{
    HTTPCustomClient clientClass = new HTTPCustomClient();
    private readonly FileHandler fileHandler = new FileHandler();
    private DataManager? manager;

    private void WelcomeMessage()
    {
        AnsiConsole.Write(new Panel("[maroon]OldSchool [grey23]RuneScape CLI[/]")
        .Header("")
        .Border(BoxBorder.Rounded)
        .Padding(1, 1)
        );
    }


    public async Task RunCLI()
    {

        while (true)
        {

            //WelcomeMessage();

            var command = AnsiConsole.Prompt(new SelectionPrompt<string>().Title("Select [green] command[/]:").AddChoices("fetch", "ehp", "ttm", "exit"));

            switch (command)
            {
                case "fetch":
                    var rsn = AnsiConsole.Ask<string>("Enter RNS");
                    await clientClass.GetUserData(rsn);
                    break;
                case "ehp":
                    manager!.GetEHP();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    throw new ArgumentException("Invalid argument selected! Exiting...");
            }
            AnsiConsole.WriteLine();
            AnsiConsole.Markup("[grey50]Press Enter key to return to menu...[/]");
            Console.ReadLine();
            AnsiConsole.Clear();
        }
    }
}