using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Project> Project { get; set; }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<Team_Members> Team_Members { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<WorkLogs> WorkLogs { get; set; }

    }
}
