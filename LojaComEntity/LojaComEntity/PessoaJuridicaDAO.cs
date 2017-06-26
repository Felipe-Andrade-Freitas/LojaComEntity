using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class PessoaJuridicaDAO
    {
        private ModelContext context;

        public PessoaJuridicaDAO(ModelContext context)
        {
            this.context = context;
        }

        public void AdicionaESalvaPJ(string nome, string cnpj, string senha)
        {
            PessoaJuridica PJ = new PessoaJuridica()
            {
                Nome = nome,
                CNPJ = cnpj,
                Senha = senha
            };

            context.Add(PJ);
            context.SaveChanges();
        }
    }
}
