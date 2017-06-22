using LojaComEntity.Model;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioDao dao = new UsuarioDao();
            ModelContext contexto = new ModelContext();

            //Usuario vitor = new Usuario()
            //{
            //    Nome = "vitor".ToUpper(),
            //    Senha = "123".ToUpper()
            //};
            //dao.Salva(vitor);

            //dao.RemoveUsuario(vitor);

            //usuario.Nome = "Vitor Saggio";
            //dao.SaveChanges();

            //Usuario renam = dao.BuscaPorId(2);
            //Usuario usuario = dao.BuscaPorId(3);
            //var id = dao.BuscaPorId(1);

            //Console.WriteLine("buscou o usuário {0} com o ID {1}", id.Nome, id.ID);
            //Console.WriteLine("buscou o usuário {0} com o ID {1}", usuario.Nome, usuario.ID);
            //Console.WriteLine("Removeu o usuário {0} com o ID {1}", renam.Nome, renam.ID);

            Console.WriteLine("====================================================================");

            //Categoria cat = new Categoria()
            //{
            //    Nome = "Roupa".ToUpper()
            //};
            //contexto.Categorias.Add(cat);
            //contexto.SaveChanges();

            //var cate = contexto.Categorias.FirstOrDefault(c => c.ID == 2);
            
            //Produto prod = new Produto()
            //{
            //    Nome = "teclado".ToUpper(),
            //    Preco = 20,
            //    Categoria = cate
            //};
            //contexto.Produtos.Add(prod);
            //contexto.SaveChanges();

            //Console.WriteLine("A Categoria {0} foi salva no banco", cat.Nome);
            //Console.WriteLine("O Produto {0} foi adicionado com a Categoria {1}", prod.Nome, prod.Categoria.Nome);

            //var pro = contexto.Produtos.Include(c => c.Categoria).FirstOrDefault(p=> p.ID == 1);
            //Console.WriteLine("O produto {0} tem a categoria {1} ",pro.Nome, pro.Categoria.Nome);

            Console.WriteLine("====================================================================");

            CategoriaDAO daoc = new CategoriaDAO(contexto);
            VendaDAO vendDao = new VendaDAO(contexto);
            

            var result = daoc.BuscaPorNomePrecoCategoria(null, 20, null);

            foreach(var p in result)
            {
                Console.WriteLine(p.Nome);
            }

            Console.WriteLine("====================================================================");


            Usuario was = dao.BuscaPorId(1);

            Venda v = new Venda()
            {
                Cliente = was
            };
            //vendDao.AdicionaVenda(v);

            ProdutoDAO prod = new ProdutoDAO();
            Produto p1 = prod.BuscaPorID(1);
            Produto p2 = prod.BuscaPorID(2);       

            ProdutoVenda prodv = new ProdutoVenda()
            {
                Venda =v,
                Produto = p1
            };
            
            ProdutoVenda prodv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p2
            };
            contexto.ProdutoVenda.Add(prodv2);
            contexto.ProdutoVenda.Add(prodv);

            Console.ReadKey();
        }
    }
}
