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
    }
}
