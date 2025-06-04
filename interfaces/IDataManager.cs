public interface IDataManager
{
    /// <summary>
    /// Read a JSON dataset
    /// </summary>
    /// <param name="dataSet">a JSON dataset</param>
    /// <returns>a JSON dataset passed to a string array</returns>
    string ReadDataSet(string dataSet);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dataSet">a JSON dataset</param>
    void GetUsefulData(string dataSet);

    /// <summary>
    /// Target the JSON dataset and print information about time to max
    /// </summary>
    /// <returns>string</returns>
    string TimeToMax();
    /// <summary>
    /// Target the JSON dataset and print information about EHP
    /// </summary>
    /// <returns>string</returns>
    string GetEHP();
    /// <summary>
    /// Target the JSON dataset and print information about efficient bossing
    /// </summary>
    /// <returns>string</returns>
    string GetBossActivity();
}