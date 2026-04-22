using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<User> Users {get; set; }
    public DbSet<ExMember> ExMembers {get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=localhost;Database=JCFMembers;Trusted_Connection=True;TrustServerCertificate=True;");
    // }
}