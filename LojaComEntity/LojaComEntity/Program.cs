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

            //Usuario vitor = new Usuario()
            //{
            //    Nome = "vitor".ToUpper(),
            //    Senha = "123".ToUpper()
            //};
            //manipulador.Salva(vitor);
            Usuario vitor = dao.BuscaPorId(2);
            Usuario usuario = dao.BuscaPorId(3);
            var id = dao.BuscaPorId(1);

            dao.RemoveUsuario(vitor);

            Console.WriteLine("buscou o usuário {0} com o ID {1}", id.Nome, id.ID);
            Console.WriteLine("buscou o usuário {0} com o ID {1}", usuario.Nome, usuario.ID);
            Console.WriteLine("Removeu o usuário {0} com o ID {1}", vitor.Nome, vitor.ID);

            Console.ReadKey();
        }
    }
}
