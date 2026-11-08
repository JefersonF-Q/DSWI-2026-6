using DSWI_sesion02.Models;
using Microsoft.EntityFrameworkCore;

namespace DSWI_sesion02.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
