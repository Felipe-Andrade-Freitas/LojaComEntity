using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using LojaComEntity;

namespace LojaComEntity.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20170622200007_CriaVenda")]
    partial class CriaVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LojaComEntity.Model.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("LojaComEntity.Model.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("LojaComEntity.Model.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaID");

                    b.Property<int>("ProdutoID");

                    b.HasKey("VendaID", "ProdutoID");
                });

            modelBuilder.Entity("LojaComEntity.Model.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("LojaComEntity.Model.Venda", b =>
                {
                    b.Property<int>("VendaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteID");

                    b.HasKey("VendaId");
                });

            modelBuilder.Entity("LojaComEntity.Model.Produto", b =>
                {
                    b.HasOne("LojaComEntity.Model.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("LojaComEntity.Model.ProdutoVenda", b =>
                {
                    b.HasOne("LojaComEntity.Model.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID");

                    b.HasOne("LojaComEntity.Model.Venda")
                        .WithMany()
                        .HasForeignKey("VendaID");
                });

            modelBuilder.Entity("LojaComEntity.Model.Venda", b =>
                {
                    b.HasOne("LojaComEntity.Model.Usuario")
                        .WithMany()
                        .HasForeignKey("ClienteID");
                });
        }
    }
}
