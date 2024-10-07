using Microsoft.EntityFrameworkCore;

namespace UsersAPI.Model
{
    public class UsersContext : DbContext
    {
        public UsersContext() { }

        public UsersContext(DbContextOptions options) : base(options) 
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder != null)
            {
           
                string conn = "server=localhost; database=Users; user=root; password=";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }
        DbSet<User> Users { get; set; } = null!; 

    }
}
