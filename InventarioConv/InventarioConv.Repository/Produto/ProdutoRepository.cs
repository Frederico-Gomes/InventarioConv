using InventarioConv.Borders.DTO.Produto;
using InventarioConv.Borders.Repository.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConv.Repository.Produto
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Context dbContext;
        public ProdutoRepository(Context dbContext)
        {
            this.dbContext = dbContext as Context;
        }

        public Borders.Entities.Produto criaProduto(Borders.Entities.Produto produto)
        {
            dbContext.Produto.Add(produto);
            dbContext.SaveChanges();

            return produto;
        }

        public Borders.Entities.Produto editaProduto(EditaProdutoRequest request)
        {
            var produto = dbContext.Produto.Find(request.ID);
            if (produto == null)   return produto;

            produto.Nome = request.Nome;
            produto.Descricao = request.Descricao;
            produto.Quantidade = request.Quantidade;
            produto.Tipo = request.Tipo;
            dbContext.SaveChanges();
            return produto;

        }

        public IEnumerable<Borders.Entities.Produto> listaTodos()
        {
            return dbContext.Produto.ToList();
        }

        public Borders.Entities.Produto procuraProduto(ProcuraProdutoRequest request)
        {
            return dbContext.Produto.Find(request.Id);
        }

        public Borders.Entities.Produto removeProduto(RemoveProdutoRequest request)
        {
            var produto = dbContext.Produto.Find(request.Id);
            if (produto == null) return produto;
            dbContext.Produto.Remove(produto);
            dbContext.SaveChanges();
            return produto;
        }
    }
}
