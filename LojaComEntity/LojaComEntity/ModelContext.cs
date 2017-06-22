using LojaComEntity.Model;
using Microsoft.Data.Entity;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class ModelContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["LojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
