using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaComEntity.Model
{
    public class Venda
    {
        public int VendaId { get; set; }

        public int ClienteID { get; set; }

        public virtual Usuario Cliente { get; set; }
        
        public virtual IList<ProdutoVenda> ProdutoVenda { get; set; }

    }
}
