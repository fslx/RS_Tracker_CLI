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
    void TimeToMax();
    /// <summary>
    /// Target the JSON dataset and print information about EHP
    /// </summary>

    void GetEHP();
    /// <summary>
    /// Target the JSON dataset and print information about efficient bossing
    /// </summary>
    void GetBossActivity();
}