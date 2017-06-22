﻿using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class VendaDAO
    {
        private ModelContext contexto;

        public VendaDAO(ModelContext contexto)
        {
            this.contexto = contexto;
        }

        public void AdicionaVenda(Venda Venda)
        {
            contexto.Add(Venda);
            contexto.SaveChanges();
        }
    }
}
