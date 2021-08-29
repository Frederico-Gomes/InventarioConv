using InventarioConv.Borders.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.DTO.Produto
{
    public class EditaProdutoRequest
    {
        [Required]
        public Guid ID { get; set; }
        [MaxLength(30)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        [Range(1, uint.MaxValue)]
        public uint Quantidade { get; set; }
        public TipoEnum Tipo { get; set; }
    }
}
