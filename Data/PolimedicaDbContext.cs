using Microsoft.EntityFrameworkCore;
using PolimedicaSite.Models;
using Site_Polimedica.Models;

namespace PolimedicaSite.Data
{
    public class PolimedicaDbContext : DbContext
    {
        public PolimedicaDbContext(DbContextOptions<PolimedicaDbContext> options) : base(options)
        {
            
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
