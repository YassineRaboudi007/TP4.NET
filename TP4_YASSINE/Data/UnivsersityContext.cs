using Microsoft.EntityFrameworkCore;
using TP4_YASSINE.Models;

namespace TP4_YASSINE.Data
{
    public class UnivsersityContext : DbContext
    {
        private static UnivsersityContext context;
        private UnivsersityContext(DbContextOptions dbContextOptions) : base(dbContextOptions){}
        public static UnivsersityContext Instantiate_UniversityContext(
            IConfiguration configuration
        ){
            if (context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UnivsersityContext>();
                optionsBuilder.UseSqlite($"Filename={configuration.GetConnectionString("SQLite")}");
                context = new UnivsersityContext(optionsBuilder.Options);
                return context;

            }
            return context;
        }

        public DbSet<Student> Student { get; set; }
    }
}
