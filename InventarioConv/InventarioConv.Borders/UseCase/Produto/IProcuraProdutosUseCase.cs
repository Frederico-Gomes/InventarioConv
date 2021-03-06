using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.UseCase.Produto
{
    public interface IProcuraProdutosUseCase : IUseCase<ProcuraProdutoRequest, Borders.Entities.Produto>
    {
    }
}
