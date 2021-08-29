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
    public class RemoveProdutoUseCase : IRemoveProdutoUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public RemoveProdutoUseCase(IProdutoRepository repository)
        {
            this.produtoRepository = repository;
        }
        public Borders.Entities.Produto Execute(RemoveProdutoRequest request)
        {
            return produtoRepository.removeProduto(request);
        }
    }
}
