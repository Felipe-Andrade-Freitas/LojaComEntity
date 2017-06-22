using LojaComEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity
{
    class UsuarioDao
    {
        private ModelContext contexto;

        public UsuarioDao()
        {
            contexto = new ModelContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u=> u.ID == id);
        }

        public void RemoveUsuario(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
    }
}
