public class SnapshotDTO
{
    public int ID { get; set; }
    public int PlayerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public SnapshotDTO ImportedAt { get; set; } = null!;
    public List<RSChar>? Data { get; set; }

}