using Microsoft.EntityFrameworkCore;

namespace OracleBug31423881
{
    internal class MyDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseOracle("Data Source=127.0.0.1:1521/ORCL;User Id=userId;Password=password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityTypeBuilder = modelBuilder.Entity<Blog>();
            entityTypeBuilder.Property(b => b.Url).IsRequired();
            entityTypeBuilder.Property(b => b.CreationDate).HasColumnType("Date");
        }
    }
}
