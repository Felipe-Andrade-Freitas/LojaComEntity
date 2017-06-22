using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    public class CategoriaDAO
    {
        private ModelContext contexto;
        public CategoriaDAO(ModelContext contexto)
        {
            this.contexto = contexto;
        }

        public void Salvar(Categoria categoria)
        {
            contexto.SaveChanges();
        }

        public void AdicionaCategoria(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
        }

        public void RemoveCategoria(Categoria categoria)
        {
            contexto.Categorias.Remove(categoria);
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.FirstOrDefault(p=> p.ID == id);
        }

        public IList<Produto> BuscaPorNomePrecoCategoria(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos
                        select p;

            if (!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p=> p.Nome == nome);
            }

            if (preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if (!String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
        }
    }
}
