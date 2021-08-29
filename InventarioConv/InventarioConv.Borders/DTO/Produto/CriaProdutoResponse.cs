using InventarioConv.Borders.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.DTO.Produto
{
    public class CriaProdutoResponse
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public uint Quantidade { get; set; }
        public TipoEnum Tipo { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Menssagem { get; set; }
    }
}
