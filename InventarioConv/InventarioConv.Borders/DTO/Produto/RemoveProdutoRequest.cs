using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.DTO.Produto
{
    public class RemoveProdutoRequest
    {
        [Required]
        public Guid Id{ get; set; }
    }
}
