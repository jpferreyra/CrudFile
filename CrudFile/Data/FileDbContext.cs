using Microsoft.EntityFrameworkCore;

namespace CrudFile.Data
{
    public class FileDbContext : DbContext
    {
        public FileDbContext()
        {

        }
        public FileDbContext(DbContextOptions<FileDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<dbFile> dbFiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Constants.ConnectionString);
            }
        }
    }
}
