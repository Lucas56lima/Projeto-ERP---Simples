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
            //Busca a Query para atualizar o Estoque utilizando os parametros produto,quantidade,valorUnitario,valorTotal
            string queryUpdateEstoque = _consultaSQL.ObterConsulta("AtualizaEstoque");
            //Busca as informações de estoque atual do produto 
            string informacoesEstoque = _consultaSQL.ObterConsulta("RecuperaInformacoesEstoque");
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                try
                {
                    var produtoInfo = conn.QueryFirstOrDefault<ProdutoInfoCommand>(informacoesEstoque, new { produto = estoque.produto });
                    if (produtoInfo == null)
                    {
                        throw new Exception("Produto não existe");
                    }
                    var parameters = new DynamicParameters();
                    var qtdAtualizada = produtoInfo.Quantidade + estoque.quantidade;
                    var valorTotalAtualizado = produtoInfo.Total + estoque.valorTotal;
                    var valorUnitario = valorTotalAtualizado / qtdAtualizada;
                    parameters.AddDynamicParams(new { Produto = estoque.produto, Quantidade = qtdAtualizada, ValorUnitario = valorUnitario });
                    conn.Query(queryUpdateEstoque, parameters);

                    return "Estoque atualizado";
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        throw new Exception("Produto não existe");
                    else
                        throw new Exception("Erro ao conectar com o banco!");
                }
            }
        }
    }    
}

