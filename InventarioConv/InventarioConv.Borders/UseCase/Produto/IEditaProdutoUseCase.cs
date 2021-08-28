using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.UseCase.Produto
{
    interface IEditaProdutoUseCase : IUseCase<EditaProdutoRequest, Borders.Entities.Produto>
    {
    }
}
