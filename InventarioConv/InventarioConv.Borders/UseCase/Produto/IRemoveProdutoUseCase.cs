using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.UseCase.Produto
{
    interface IRemoveProdutoUseCase : IUseCase<RemoveProdutoRequest, Borders.Entities.Produto>
    {
    }
}
