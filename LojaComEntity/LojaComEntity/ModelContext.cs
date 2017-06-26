﻿using LojaComEntity.Model;
using Microsoft.Data.Entity;
using System.Configuration;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class ModelContext : Microsoft.Data.Entity.DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Venda> Vendas { get; set; }

        public DbSet<ProdutoVenda> ProdutoVenda { get; set; }

        public DbSet<PessoaFisica> PessoaFisica { get; set; }

        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["LojaConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(stringConexao);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoVenda>().HasKey(pv => new { pv.VendaId, pv.ProdutoID});
            base.OnModelCreating(modelBuilder);
        }
    }
}
