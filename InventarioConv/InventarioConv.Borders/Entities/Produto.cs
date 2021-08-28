using InventarioConv.Borders.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.Entities
{
    class Produto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public uint Quantidade { get; set; }
        public TipoEnum Tipo{ get; set; }
    }
}
