﻿using InventarioConv.Borders.DTO.Produto;
using InventarioConv.Borders.Repository.Produto;
using InventarioConv.Borders.UseCase.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.UseCase.Produto
{
    public class ListaProdutosUseCase : IListaProdutosUseCase
    {
        private readonly IProdutoRepository produtoRepository;
        public ListaProdutosUseCase(IProdutoRepository repository)
        {
            this.produtoRepository = repository;
        }

        public Borders.Entities.Produto Execute(ListaProdutosRequest request)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Borders.Entities.Produto> IListaProdutosUseCase.Execute()
        {
            return produtoRepository.listaTodos();
        }
    }
}
