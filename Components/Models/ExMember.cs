public class ExMember
{
    public int Id { get; set; }
    public int consNum { get; set; }
    public DateOnly termDate { get; set; }
    public string regNum { get; set; }
    public string rank { get; set; }
    public string name { get; set; }
    public string lastDiv { get; set; }
    public string termReason { get; set; }
    public string forceOrdersNum { get; set; }
    public int createdBy { get; set; }
    public User User { get; set; }
    public DateOnly createdOn { get; set; }
}
