using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CRUD_PRODUTOS.Models

{
    public class AppDbContext : DbContext
    // : DbContext se trata de uma herenca
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }



    }
}
