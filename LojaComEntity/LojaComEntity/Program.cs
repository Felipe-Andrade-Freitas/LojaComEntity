using LojaComEntity.Model;
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
            //manipulador.Salva(vitor);

            //dao.RemoveUsuario(vitor);

            //usuario.Nome = "Vitor Saggio";
            //dao.SaveChanges();

            Usuario renam = dao.BuscaPorId(2);
            Usuario usuario = dao.BuscaPorId(3);
            var id = dao.BuscaPorId(1);

            Console.WriteLine("buscou o usuário {0} com o ID {1}", id.Nome, id.ID);
            Console.WriteLine("buscou o usuário {0} com o ID {1}", usuario.Nome, usuario.ID);
            //Console.WriteLine("Removeu o usuário {0} com o ID {1}", renam.Nome, renam.ID);

            Console.WriteLine("====================================================================");

            Categoria cat = new Categoria()
            {
                Nome = "Informatica".ToUpper()
            };
            contexto.Categorias.Add(cat);
            contexto.SaveChanges();

            Produto prod = new Produto()
            {
                Nome = "mouse".ToUpper(),
                Preco = 20,
                Categoria = cat
            };
            contexto.Produtos.Add(prod);
            contexto.SaveChanges();

            Console.WriteLine("A Categoria {0} foi salva no banco", cat.Nome);
            Console.WriteLine("O Produto {0} foi adicionado com a Categoria {1}", prod.Nome, prod.Categoria.Nome);

            Console.ReadKey();
        }
    }
}
