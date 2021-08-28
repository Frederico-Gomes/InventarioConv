using InventarioConv.Borders.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.DTO.Produto
{
    class CriaProdutoRequest
    {
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Required]
        [Range(1, uint.MaxValue]
        public uint Quantidade { get; set; }
        public TipoEnum Tipo{ get; set; }
    }
}
