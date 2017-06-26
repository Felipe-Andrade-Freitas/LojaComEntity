using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class PessoaFisicaDAO
    {
        private ModelContext contexto;

        public PessoaFisicaDAO(ModelContext contexto)
        {
            this.contexto = contexto;
        }

        public void AdicionaESalvaPF(Usuario usuario)
        {
            //string nome, string cpf, string senha
            //PessoaFisica usuario = new PessoaFisica()
            //{
            //    Nome = nome,
            //    CPF = cpf,
            //    Senha = senha
            //};


            contexto.Add(usuario);
            contexto.SaveChanges();
        }
    }
}
