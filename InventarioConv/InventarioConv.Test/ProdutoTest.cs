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
        public void BuscaProduto()
        {
            // Arrange
            var produtoRepository = new Mock<IProdutoRepository>();
            IUseCase<ProcuraProdutoRequest, Borders.Entities.Produto> produtosUseCase = new ListaProdutosUseCase(produtoRepository.Object);

            var produtoRequest = new ProcuraProdutoRequest() {Id = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f") };

            var coca = new Produto { ID = Guid.Parse("c1ce3a61-33b7-42bb-b0b0-b11b2b8ec65f"), Nome = "Coca-Cola Lata", Descricao = "Regrigerante 350ml", Quantidade = 40, Tipo = Borders.Enum.TipoEnum.Alimenticios };

            produtoRepository.Setup(x => x.ProcuraProduto(It.IsAny<ProcuraProdutoRequest>())).Returns(coca);

            var produtoResponse = produtosUseCase.Execute(produtoRequest);

            Assert.True(produtoResponse.ID == produtoRequest.Id);
        }
    }
}
