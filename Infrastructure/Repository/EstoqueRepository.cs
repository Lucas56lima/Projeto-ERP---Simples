using System.Data.SqlClient;
using Domain.Commands;
using Domain.Interface;
using Dapper;

namespace Infrastructure.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        string conexao = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";

        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string queryUpdateEstoque = @"UPDATE Estoque 
                SET quantidade=@quantidade,valorUnitario=@valorUnitario,total=@quantidade * @valorUnitario
                WHERE produto=@produto   
                ";

                string getQuantidade = "SELECT quantidade FROM Estoque WHERE produto = @produto";
                string getValorUnitario = "SELECT valorUnitario FROM Estoque WHERE produto = @produto";
                string getTotal = "SELECT total FROM Estoque WHERE produto = @produto";

                var qtdProduto = conn.Query<int>(getQuantidade, new { produto = estoque.produto }).FirstOrDefault();
                var vlrUniProduto = conn.Query<decimal>(getValorUnitario, new { produto = estoque.produto }).FirstOrDefault();
                var valorTotal = conn.Query<decimal>(getTotal, new {produto = estoque.produto}).FirstOrDefault();

                estoque.valorTotal = estoque.valorUnitario * qtdProduto;

                valorTotal += estoque.valorTotal;

                conn.Query(queryUpdateEstoque, new EstoqueCommand
                {
                    quantidade = qtdProduto + estoque.quantidade,
                    valorUnitario = valorTotal/(vlrUniProduto + estoque.valorUnitario),
                    produto = estoque.produto
                });

                return "Estoque atualizado";

            }
        }
    }
}
