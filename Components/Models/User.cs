public class User
{
    public int userID { get; set; }
    public string userName { get; set; }
    public string pword { get; set; }
    public string email { get; set; }
    public string? resetToken { get; set; }
    public DateOnly? tokenExpiry { get; set; }
}