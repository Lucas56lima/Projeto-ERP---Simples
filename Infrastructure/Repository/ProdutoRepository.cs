using System.Data.SqlClient;
using Domain.Commands;
using Domain.Interface;
using Dapper;

namespace Infrastructure.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        string conexao = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            
            string queryInsert = @"
            INSERT INTO CadastroProduto (codigoProduto,descricao,precoProduto,categoria,subCategoria,marca,cor) VALUES
            (@codigoProduto,@descricao,@precoProduto,@categoria,@subCategoria,@marca,@cor)
            ";
            

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {


                    descricao = command.descricao,
                    precoProduto = command.precoProduto,
                    categoria = (int)command.categoria,
                    subCategoria = (int)command.subCategoria,
                    marca = (int)command.marca,
                    cor = (int)command.cor,
                    codigoProduto = conn.QueryAsync(@"SELECT numero FROM CadCategoria WHERE categoriaID=@categoria",new
                    {
                        
                    })
                }); ;
            }

            return "Produto Cadastrado com sucesso!";
        }
    }
}
