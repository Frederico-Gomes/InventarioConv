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
    public class CriaProdutoUseCase : ICriaProdutoUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public CriaProdutoUseCase(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public Borders.Entities.Produto Execute(CriaProdutoRequest request)
        {
            Borders.Entities.Produto produto = new Borders.Entities.Produto
            {
                ID = Guid.NewGuid(),
                Nome = request.Nome,
                Descricao = request.Descricao,
                Quantidade = request.Quantidade,
                Tipo = request.Tipo

            };
            return produtoRepository.criaProduto(produto);
        }
    }
}