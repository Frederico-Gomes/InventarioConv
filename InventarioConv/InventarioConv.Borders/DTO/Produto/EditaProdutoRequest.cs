using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.DTO.Produto
{
    class EditaProdutoRequest
    {
        [Required]
        public Guid Id { get; set; }
    }
}
