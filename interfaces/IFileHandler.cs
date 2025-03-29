public interface IFileHandler
{
    /// <summary>
    /// Create a new file in CWD
    /// </summary>
    /// <param name="fileName">Name of the file to create!</param>
    void CreateNewFile(string? fileName);
    /// <summary>
    /// Update the filedata
    /// </summary>
    /// <param name="filePath">Name of the file to write to</param>
    void UpdateFileData(string filePath);
    /// <summary>
    /// Delete a file when overwritten or when it needs to be discarded.
    /// </summary>
    /// <param name="fileName">Name of the file to delete</param>
    void DeleteFile(string? fileName);
}