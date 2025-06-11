using System.Text.Json;

public class DataManager : IDataManager
{
    private readonly HTTPCustomClient? client;

    private FileHandler? userInfo;
    private string FetchInternalJSONData()
    {
        string userData = userInfo!.SendRSN();
        var data = client!.GetUserData(userData);
        return data.ToString()!;
    }


    public void GetEHP()
    {
        string filePath = FetchInternalJSONData();
        string[] file = File.ReadAllLines(filePath);
        foreach (string f in file)
        {
            Console.WriteLine($"Time To Max: {f} {f == "ttm"}");
        }
    }

    public void GetUsefulData(string dataSet)
    {
        string filePath = FetchInternalJSONData();
        string[] file = File.ReadAllLines(filePath);
        foreach (string f in file)
        {
            Console.WriteLine($"Time To Max: {f} {f == "ttm"}");
        }
    }

    public string ReadDataSet(string dataSet)
    {
        var file = File.ReadAllText(dataSet);
        string[] set = dataSet.Split(file);
        foreach (string s in set)
        {
            return s;
        }
        return dataSet;
    }

    public void TimeToMax()
    {
        string filePath = FetchInternalJSONData();
        string[] file = File.ReadAllLines(filePath);
        foreach (string f in file)
        {
            Console.WriteLine($"Time To Max: {f} {f == "ttm"}");
        }
    }



    void IDataManager.GetBossActivity()
    {
        throw new NotImplementedException();
    }
}