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


        /// <summary>
        /// Procura todos os produtos cadastrados no banco de dados
        /// </summary>
        ///<response code = "200" > Lista todos os produtos cadastrados </response>
        ///<response code = "404" > Nenhum produto cadastrado até o momento</response>
        [HttpGet]
        [Route("/listaTodos")]
        public IActionResult listarProdutos()
        {
            var produtos = listaProdutosUseCase.buscaTodos();
            if (produtos.Count() == 0) return NotFound("Nenhum produto cadastrado");
            return Ok(produtos);
        }
        /// <summary>
        /// Procura um produto específico utilizando seu ID
        /// </summary>
        /// <param name="request"> Id do personagem desejado </param>
        ///<response code = "200" > Retorna o produto solicitado </response>
        ///<response code = "404" > Não existem nenhum produto cadastrado com o id oferecido</response>
        [HttpGet]
        public IActionResult procuraProduto([FromQuery] ProcuraProdutoRequest request)
        {
            var produto = listaProdutosUseCase.Execute(request);
            if (produto == null) return NotFound("Produto Não cadastrado");
            return Ok(produto);
        }

        /// <summary>
        /// Insere um novo produto no banco de dados
        /// </summary>
        /// <param name="request">Produto a ser inserido no banco de dados </param>
        ///<response code = "201" > Retorna o o produto cadastrado </response>
        [HttpPost]
        public IActionResult criaProduto([FromQuery] CriaProdutoRequest request)
        {
            var produto = criaProdutoUseCase.Execute(request);
            return Created("Produto criado com sucesso", produto);
        }

        /// <summary>
        /// Atualiza os dados de um produto ja inserido no banco de dados
        /// </summary>
        /// <param name="request">Objeto contendo o Id do produto a ser modificado, junto com seus novos dados</param>
        ///<response code = "200" > Retorna o produto já com os dados atualizados </response>
        ///<response code = "404" > Não existe nenhum produto cadastrado no banco de dados com o Id informado </response>

        [HttpPut]
        public IActionResult editaProduto([FromQuery] EditaProdutoRequest request)
        {
            var produto = editaProdutoUseCase.Execute(request);
            if (produto == null) return NotFound("Produto Não cadastrado");
            return Ok(produto);
        }

        /// <summary>
        /// Remove um produto do banco de dados
        /// </summary>
        /// <param name="request">Id do produto a ser removido </param>
        ///<response code = "200" > Retorna o produto </response>
        ///<response code = "404" > Não existe nenhum produto cadastrado no banco de dados com o Id informado </response>
        [HttpDelete]
        public IActionResult removeProduto([FromQuery] RemoveProdutoRequest request)
        {
            var produto = removeProdutoUseCase.Execute(request);
            if (produto == null) return NotFound("Produto Não cadastrado");
            return Ok(produto);
        }

    }
}
