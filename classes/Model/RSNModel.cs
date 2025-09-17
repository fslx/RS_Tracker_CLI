using System.ComponentModel.DataAnnotations;

public class RNSModel
{
    /// <summary>
    /// RuneScape Account name
    /// </summary>
    public string? RNS { get; set; }
    [RegularExpression("Regular || Ironman")]
    public string? Type { get; set; }
    /// <summary>
    /// Account builds
    /// </summary>
    [RegularExpression("Normal || Ironman || Hardcore Ironman || Ultimate Ironman || Deadman Mode || 1-Defence Pure || Zerker || Level-3 Skiller || ")]
    public string? AccountBuild { get; set; }
    public string? Country { get; set; } = null;
    public string? Status { get; set; } = "Active";
    public bool Patron { get; set; } = false;
    public double TotalExperience { get; set; }
    public double EHP { get; set; }
    public double EHB { get; set; }
    public double TimeToMax { get; set; }
    public double TimeTo200Mil { get; set; }
    /*
        Below is internal DateTime conversions done to other fields
    */
    private DateTime ParseRegisteredAt;
    private DateTime ParseUpdatedAt;
    private DateTime ParseLastChangedAt;
    private DateTime ParseLastImportedAt;
    /*
        End of internal conversions.
    */

    public string? RegisteredAt { get; set; }
    public string? UpdatedAt { get; set; }
    public string? LastChangedAt { get; set; }
    public string? LastImportedAt { get; set; } = null;
    public int CombatLevel { get; set; } = 3;
    public string? Archive { get; set; } = null;
    public string[]? Annotations { get; set; }
    public SnapshotDTO? LatestSnapshot { get; set; }
    public int TotalLevel { get; set; }
    public EHP? ComputedEHP { get; set; }
    public EHB? ComputedEHB { get; set; }
}