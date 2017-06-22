using LojaComEntity.DAO;
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
            DAOContext context = new DAOContext();

            Usuario was = new Usuario()
            {
                Nome = "Washington".ToUpper(),
                Senha = "123".ToUpper()
            };
            context.Usuarios.Add(was);
            context.SaveChanges();
            context.Dispose();

            Console.WriteLine("salvou o usuário");

            Console.ReadLine();
        }
    }
}
