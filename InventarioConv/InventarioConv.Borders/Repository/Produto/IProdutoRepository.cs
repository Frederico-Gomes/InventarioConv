using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.Repository.Produto
{
    interface IProdutoRepository : IRepository<Entities.Produto>
    {
        Entities.Produto criaProduto(CriaProdutoRequest request);
        Entities.Produto editaProduto(EditaProdutoRequest request);
        Entities.Produto removeProduto(RemoveProdutoRequest request);
    }
}
