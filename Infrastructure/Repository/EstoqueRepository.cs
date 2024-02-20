using System.Data.SqlClient;
using Dapper;
using Domain.Commands;
using Domain.Interface;

namespace Infrastructure.Repository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly string _connectionString;
        private readonly IConsultaSQL _consultaSQL;
        public string ConnectionString { get; }

        /// <summary>
        /// Inicializa uma nova instância do repositório de produtos.
        /// </summary>
        /// <param name="connectionString">A string de conexão com o banco de dados.</param>
        /// <param name="consultaSQL"> Recupera as consultas SQL do COnsultaSQLResource</param>

        public EstoqueRepository(string connectionString, IConsultaSQL consultaSQL)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _consultaSQL = consultaSQL ?? throw new ArgumentNullException(nameof(consultaSQL));
        }
        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {
            string queryUpdateEstoque = _consultaSQL.ObterConsulta("AtualizaEstoque");
            string informacoesEstoque = _consultaSQL.ObterConsulta("RecuperaInformacoesEstoque");

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    var produtoInfo = await conn.QueryFirstOrDefaultAsync<ProdutoInfoCommand>(informacoesEstoque, new { produto = estoque.produto }, transaction: tran);
                    if (produtoInfo == null)
                    {
                        tran.Rollback(); // Revertendo a transação em caso de produto não encontrado
                        throw new Exception("Produto não existe");
                    }

                    var parametros = new DynamicParameters();
                    var qtdAtualizada = produtoInfo.Quantidade + estoque.quantidade;
                    var valorTotalAtualizado = produtoInfo.Total + estoque.valorTotal;
                    var valorUnitario = valorTotalAtualizado / qtdAtualizada;

                    parametros.AddDynamicParams(new { Produto = estoque.produto, Quantidade = qtdAtualizada, ValorUnitario = valorUnitario });

                    await conn.ExecuteAsync(queryUpdateEstoque, parametros, transaction: tran);

                    tran.Commit(); // Confirmando a transação
                    return "Estoque atualizado";
                }
                catch (SqlException ex)
                {
                    tran.Rollback(); // Revertendo a transação em caso de exceção SQL

                    if (ex.Number == 547)
                        throw new Exception("Produto não existe");
                    else
                        throw new Exception("Erro ao conectar com o banco!");
                }
            }
        }

    }
}    


