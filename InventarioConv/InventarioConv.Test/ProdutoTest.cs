using InventarioConv.Borders.DTO.Produto;
using InventarioConv.Borders.Entities;
using InventarioConv.Borders.Repository.Produto;
using InventarioConv.Borders.UseCase;
using InventarioConv.UseCase.Produto;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace InventarioConv.Test
{
    public class ProdutoTest
    {
        [Fact]
        public void BuscaProdutoTest()
        {

            var produtoRepository = new Mock<IProdutoRepository>();
            IUseCase<ProcuraProdutoRequest, Borders.Entities.Produto> produtosUseCase = new ListaProdutosUseCase(produtoRepository.Object);

            var produtoRequest = new ProcuraProdutoRequest() {Id = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f") };

            var coca = new Produto
            {
                ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"),
                Nome = "Coca-cola 2L",
                Descricao = "Refrigereante 2l",
                Quantidade = 100,
                Tipo = Borders.Enum.TipoEnum.Alimenticios
             };

            produtoRepository.Setup(x => x.ProcuraProduto(It.IsAny<ProcuraProdutoRequest>())).Returns(coca);

           
            var produtoResponse = produtosUseCase.Execute(produtoRequest);

            Assert.True(produtoResponse.ID == produtoRequest.Id);
        }

        [Fact]
        public void EditaProdutoTest()
        {
            var produtoRepository = new Mock<IProdutoRepository>();
            IUseCase<EditaProdutoRequest, Borders.Entities.Produto> produtosUseCase = new EditaProdutoUseCase(produtoRepository.Object);

            var produtoRequest = new EditaProdutoRequest() { ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"), Nome= "Coca-cola 2L", Descricao = "Refrigereante 2l", Quantidade = 100,Tipo = Borders.Enum.TipoEnum.Alimenticios };

            var coca = new Produto
            {
                ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"),
                Nome = "Coca-cola 2L",
                Descricao = "Refrigereante 2l",
                Quantidade = 100,
                Tipo = Borders.Enum.TipoEnum.Alimenticios
            };
            produtoRepository.Setup(x => x.EditaProduto(It.IsAny<EditaProdutoRequest>())).Returns(coca);

            var produtoResponse = produtosUseCase.Execute(produtoRequest);

            Assert.True(produtoResponse.Nome == produtoRequest.Nome);
        }

        [Fact]
        public void CriaProdutoTest()
        {
            var produtoRepository = new Mock<IProdutoRepository>();
            IUseCase<CriaProdutoRequest, Borders.Entities.Produto> produtosUseCase = new CriaProdutoUseCase(produtoRepository.Object);

            var coca = new Produto
            {
                ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"),
                Nome = "Coca-cola 2L",
                Descricao = "Refrigereante 2l",
                Quantidade = 100,
                Tipo = Borders.Enum.TipoEnum.Alimenticios
            };

            var produtoRequest = new CriaProdutoRequest() {Nome = "Coca-cola 2L", Descricao = "Refrigereante 2l", Quantidade = 100, Tipo = Borders.Enum.TipoEnum.Alimenticios };
            produtoRepository.Setup(x => x.CriaProduto(It.IsAny<Produto>())).Returns(coca);

            var produtoResponse = produtosUseCase.Execute(produtoRequest);
            Assert.True(produtoResponse.Nome == produtoRequest.Nome);
        }

        [Fact]
        public void RemoveProdutoTest()
        {
            var produtoRepository = new Mock<IProdutoRepository>();
            IUseCase<RemoveProdutoRequest, Borders.Entities.Produto> produtosUseCase = new RemoveProdutoUseCase(produtoRepository.Object);

            var coca = new Produto
            {
                ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"),
                Nome = "Coca-cola 2L",
                Descricao = "Refrigereante 2l",
                Quantidade = 100,
                Tipo = Borders.Enum.TipoEnum.Alimenticios
            };
            var produtoRequest = new RemoveProdutoRequest() { Id = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f") };
            produtoRepository.Setup(x => x.RemoveProduto(It.IsAny<RemoveProdutoRequest>())).Returns(coca);

            var produtoResponse = produtosUseCase.Execute(produtoRequest);
            Assert.True(produtoResponse.ID == produtoRequest.Id);
        }
    }
}
