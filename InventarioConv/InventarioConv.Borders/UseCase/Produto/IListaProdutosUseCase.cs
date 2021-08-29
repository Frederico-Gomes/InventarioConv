using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.UseCase.Produto
{
    public interface IListaProdutosUseCase : IUseCase<ListaProdutosRequest, Borders.Entities.Produto>
    {
       IEnumerable<Borders.Entities.Produto> Execute(ListaProdutosRequest request);
    }
}
