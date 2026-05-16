using System.ComponentModel.DataAnnotations.Schema;

public class SecurityQuestions
{
    public int id { get; set;}
    public string question { get; set; }
    public string answerHash { get; set; }

    public int UserId { get; set; }
    [ForeignKey("UserId")]
    public User User;
}
