public interface IDataManager 
{
    /// <summary>
    /// Read a JSON dataset
    /// </summary>
    /// <param name="dataSet">a JSON dataset</param>
    /// <returns>a JSON dataset passed to a string array</returns>
    string[] ReadDataSet(string dataSet);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dataSet">a JSON dataset</param>
    void GetUsefulData(string dataSet);
}