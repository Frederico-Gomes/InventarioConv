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
    class EditaProdutoUseCase : IEditaProdutoUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public EditaProdutoUseCase(IProdutoRepository repository)
        {
            this.produtoRepository = repository;
        }
        public Borders.Entities.Produto Execute(EditaProdutoRequest request)
        {
            return produtoRepository.editaProduto(request);
        }
    }
}
