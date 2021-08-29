using InventarioConv.Borders.DTO.Produto;
using InventarioConv.Borders.UseCase.Produto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioConv.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private ICriaProdutoUseCase criaProdutoUseCase;
        private IListaProdutosUseCase listaProdutosUseCase;
        private IEditaProdutoUseCase editaProdutoUseCase;
        private IRemoveProdutoUseCase removeProdutoUseCase;
            public ProdutosController(ICriaProdutoUseCase criaProdutoUseCase, IListaProdutosUseCase listaProdutosUseCase, IEditaProdutoUseCase editaProdutoUseCase,
                IRemoveProdutoUseCase removeProdutoUseCase)
        {
            this.criaProdutoUseCase = criaProdutoUseCase;
            this.listaProdutosUseCase = listaProdutosUseCase;
            this.editaProdutoUseCase = editaProdutoUseCase;
            this.removeProdutoUseCase = removeProdutoUseCase;
        }
        [HttpPost]
        public Borders.Entities.Produto criaProduto([FromQuery] CriaProdutoRequest request)
        {
            return criaProdutoUseCase.Execute(request);
        }
         [HttpGet]
         public IEnumerable<Borders.Entities.Produto> listarProdutos()
         {
             return listaProdutosUseCase.Execute();
         }
        [HttpPut]
        public Borders.Entities.Produto editaProduto([FromQuery] EditaProdutoRequest request)
        {
            return editaProdutoUseCase.Execute(request);
        }
        [HttpDelete]
        public Borders.Entities.Produto removeProduto([FromQuery] RemoveProdutoRequest request)
        {
            return removeProdutoUseCase.Execute(request);
        }

    }
}
