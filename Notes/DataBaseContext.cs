using Microsoft.EntityFrameworkCore;
using Notes.Models;

namespace Notes
{
    public class DataBaseContext : DbContext
    {
        private static readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(_loggerFactory);
            optionsBuilder.UseSqlServer("Server=localhost\\SASHASQL;Database=Notes;Trusted_Connection=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
           modelBuilder.Entity<Tasks>().Property(x => x.Start).HasColumnType("smalldatetime");
           modelBuilder.Entity<Tasks>().Property(x => x.End).HasColumnType("smalldatetime");
           modelBuilder.Entity<User>().HasKey(x => x.Login);
           modelBuilder.Entity<Tasks>().HasKey(x => x.Id);
           modelBuilder.Entity<Tasks>().Property(x => x.Id).UseIdentityColumn();
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }


    }
}
