using LojaComEntity.DAO;
using Microsoft.Data.Entity;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class DAOContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["LojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
