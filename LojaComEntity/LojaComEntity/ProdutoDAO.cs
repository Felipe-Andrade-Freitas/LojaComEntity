using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class ProdutoDAO
    {
        private ModelContext contexto;
        
        public ProdutoDAO()
        {
            contexto = new ModelContext();
        }
        
        public Produto BuscaPorID(int id)
        {
            return contexto.Produtos.FirstOrDefault(p=> p.ID == id);
        }

        public void AdicionaProduto(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void RemoveProduto(Produto produto)
        {
            contexto.Produtos.Remove(produto);
        }

        public void AlteraCategoriaDeProd(Produto produto, Categoria categoria)
        {
            produto.Categoria.ID = categoria.ID;
            contexto.SaveChanges();
        }
    }
}
