public class FileHandler : IFileHandler
{
    public void CreateNewFile(string? fileName)
    {
        if (!File.Exists(fileName))
        {
            if (string.IsNullOrEmpty(fileName)) throw new NullReferenceException();
            File.Create(fileName);
        }
        else
        {
            throw new FileLoadException("File already exists..");
        }
    }

    public void DeleteFile(string? fileName)
    {
        Console.WriteLine($"Are you sure you want to delete the file: {fileName} y/N?");
        string? rl = Console.ReadLine();
        if (rl?.ToLower() == "y")
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new Exception("An error occured!");
            }
            File.Delete(fileName);
            Console.WriteLine("File successfully deleted!");
        }
        else
        {
            Console.WriteLine("No changes to file written..");
        }
    }

    public void UpdateFileData(string filePath, string content)
    {
        File.AppendAllText(filePath, content);
    }
}