public class RSChar
{
    /// <summary>
    /// Fields: 
    /// </summary>
    public Dictionary<string, Skills>? Data { get; set; }
}

public class Skills
{
    public string? Metric;
    public int Experience;
    public int Rank;
    public int Level;
    public double EHP;
}