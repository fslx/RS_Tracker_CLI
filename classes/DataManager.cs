using System.Text.Json;

public class DataManager : IDataManager
{
    private readonly HTTPCustomClient? client;

    private FileHandler userInfo;
    private async Task<string> FetchInternalJSONData()
    {
        string userData = userInfo.SendRSN();
        var data = client!.GetUserData(userData);
        return data.ToString()!;
    }

    public string GetBossActivity()
    {
        throw new NotImplementedException();
    }

    public string GetEHP()
    {
        throw new NotImplementedException();
    }

    public void GetUsefulData(string dataSet)
    {
        throw new NotImplementedException();
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

    public string TimeToMax()
    {
        throw new NotImplementedException();
    }
}