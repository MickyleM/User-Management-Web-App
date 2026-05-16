using Microsoft.EntityFrameworkCore;

public class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {

        if (!db.Users.Any())
        {
            var admin = new User
            {
                userName = "admin",
                pword = BCrypt.Net.BCrypt.HashPassword("1234"),
                email = "admin@jcf.com"
            };

            db.Users.Add(admin);
            await db.SaveChangesAsync();
        }

        if (!db.SecurityQuestions.Any())
        {
            var question1 = new SecurityQuestions
            {
                question = "What is your mother's maiden name?",
                answerHash = BCrypt.Net.BCrypt.HashPassword("Single"),
                UserId = 1
            };

            db.SecurityQuestions.Add(question1);
            await db.SaveChangesAsync();
        }

    }
}
