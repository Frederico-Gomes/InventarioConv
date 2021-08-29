using InventarioConv.Borders.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Borders.Repository.Produto
{
    public interface IProdutoRepository : IRepository<Entities.Produto>
    {
        Entities.Produto CriaProduto(Entities.Produto produto);
        Entities.Produto EditaProduto(EditaProdutoRequest request);
        Entities.Produto RemoveProduto(RemoveProdutoRequest request);
        Entities.Produto ProcuraProduto(ProcuraProdutoRequest request);
    }
}
