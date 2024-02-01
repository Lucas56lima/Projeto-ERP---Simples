using System.Data.SqlClient;
using Domain.Commands;
using Domain.Interface;
using Dapper;
using Domain.ViewModel;
using Domain.Entidades;
using System.Data;

namespace Infrastructure.Repository
{
    /* Inclusão do cadastro de produto*/
    public class ProdutoRepository : IProdutoRepository
    {
        string conexao = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";

       

        public async Task<string> PostAsync(ProdutoCommand command)
        {

            string queryInsert = @"
            INSERT INTO CadastroProduto (codigoProduto,descricao,precoProduto,categoria,subCategoria,marca,cor) VALUES
            (@codigoProduto,UPPER(@descricao),@precoProduto,@categoria,@subCategoria,@marca,@cor)
            ";
            string getNumCategoria = @"SELECT numero FROM CadCategoria WHERE categoriaID=@categoria";
            string updateCategoria = @"UPDATE CadCategoria SET numero=@numCategoria + 1 WHERE categoriaID=@categoria";

            string postEstoque = @"INSERT INTO Estoque (produto,descricao) VALUES(@codigoProduto,UPPER(@descricao))";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                // Obtenha o número da categoria
                var numCategoria = conn.Query<int>(getNumCategoria, new { categoria = (int)command.categoria }).FirstOrDefault();

                // Crie o código do produto usando o número da categoria, marca e cor
                var codigoProduto = $"{numCategoria}{(int)command.marca}{(int)command.cor}";

                // Execute a inserção na tabela
                conn.Execute(queryInsert, new
                {
                    descricao = string.IsNullOrWhiteSpace(command.descricao) ? string.Empty : command.descricao,
                    precoProduto = command.precoProduto,
                    categoria = (int)command.categoria,
                    subCategoria = (int)command.subCategoria,
                    marca = (int)command.marca,
                    cor = (int)command.cor,
                    codigoProduto = codigoProduto

                });

                conn.Query(updateCategoria, new
                {
                    numCategoria = numCategoria,
                    categoria = (int)command.categoria
                });

                conn.Query(postEstoque, new
                {
                    codigoProduto = codigoProduto,
                    descricao = command.descricao
                });

            }

            return "Produto Cadastrado com sucesso!";
        }

        public async Task<string> PutAsync(int codigoProduto, ProdutoCommand command)
        {
            string queryUpdate = @"
            UPDATE CadastroProduto SET descricao = UPPER(@descricao),precoProduto = @precoProduto,categoria = @categoria,
            subCategoria = @subCategoria,marca = @marca,cor = @cor WHERE codigoProduto = @codigoProduto";


            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryUpdate, new
                {
                    codigoProduto = codigoProduto,
                    descricao = string.IsNullOrWhiteSpace(command.descricao) ? string.Empty : command.descricao,
                    precoProduto = command.precoProduto,
                    categoria = (int)command.categoria,
                    subCategoria = (int)command.subCategoria,
                    marca = (int)command.marca,
                    cor = (int)command.cor,
                }); ;                

            }

            return "Produto Atualizado com sucesso";
        }

        public async Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncList()
        {
            string queryLista = @"
            SELECT *, quantidade FROM CadastroProduto as A INNER JOIN Estoque as B
            ON codigoProduto = produto";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                return await conn.QueryAsync<ProdutoCommandConsulta>(queryLista);
            }
        }

        public async Task<IEnumerable<ProdutoCommandConsulta>> GetAsyncProduto(int codigoProduto, string descricao)
        {
            string queryProduto = "";
            if (descricao == null || descricao == "" && codigoProduto != 0)
            {
               
                queryProduto = @"
            SELECT CadastroProduto.*, quantidade FROM CadastroProduto  INNER JOIN Estoque 
            ON codigoProduto = produto where CadastroProduto.codigoProduto = @codigoProduto";
            }
            else if(descricao != null && codigoProduto == 0)
            {
                
                 queryProduto= $@"
            SELECT CadastroProduto.*, Estoque.quantidade FROM CadastroProduto INNER JOIN Estoque 
            ON codigoProduto = produto WHERE CadastroProduto.descricao LIKE '%{@descricao}%'";
            }

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                
                return await conn.QueryAsync<ProdutoCommandConsulta>(queryProduto, new
                {
                    descricao = descricao,
                    codigoProduto = codigoProduto

                });
            }
        }
    }
}

