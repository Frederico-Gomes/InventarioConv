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
    class CriaProdutoUseCase : ICriaProdutoUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public CriaProdutoUseCase(IProdutoRepository repository)
        {
            this.produtoRepository = repository;
        }

        public Borders.Entities.Produto Execute(CriaProdutoRequest request)
        {
            return produtoRepository.criaProduto(request);
        }
    }
}
