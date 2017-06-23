using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class ProdutoVendaDAO
    {
        private ModelContext contexto;

        public ProdutoVendaDAO(ModelContext contexto)
        {
            this.contexto = contexto;
        }

        public ProdutoVenda AdicionaVendaEProd(Venda venda, Produto produto)
        {
            ProdutoVenda prodVend = new ProdutoVenda()
            {
                Venda = venda,
                Produto = produto
            };

            return prodVend;
        }

        public void SalvarProdutoVenda(ProdutoVenda produto)
        {
            contexto.ProdutoVenda.Add(produto);
            contexto.SaveChanges();
        }
    }
}
