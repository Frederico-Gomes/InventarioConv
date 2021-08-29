using InventarioConv.Borders.DTO.Produto;
using InventarioConv.Borders.Repository.Produto;
using InventarioConv.Borders.UseCase.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.UseCase.Produto
{
    public class ProcuraProdutosUseCase : IProcuraProdutosUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public ProcuraProdutosUseCase(IProdutoRepository repository)
        {
            this.produtoRepository = repository;
        }

        public Borders.Entities.Produto Execute(ProcuraProdutoRequest request)
        {
            return produtoRepository.ProcuraProduto(request);
        }
    }
}
