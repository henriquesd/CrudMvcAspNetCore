using Microsoft.EntityFrameworkCore;  
  
namespace CrudMvcAspNetCore.Models  
{  
    public class CrudMvcAspNetCoreContext : DbContext  
    {  
        public CrudMvcAspNetCoreContext (DbContextOptions<CrudMvcAspNetCoreContext> options)  
            : base(options)  
        {  
        }  
  
        public DbSet<CrudMvcAspNetCore.Models.Publisher> Publisher { get; set; }  
        public DbSet<CrudMvcAspNetCore.Models.Author> Author { get; set; }  
        public DbSet<CrudMvcAspNetCore.Models.Book> Book { get; set; }  
    }  
}  