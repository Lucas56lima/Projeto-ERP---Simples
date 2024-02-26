using System.Data.SqlClient;
using Dapper;
using Domain.Commands;
using Domain.Interface;

namespace Infrastructure.Repository
{
    /* Inclusão do cadastro de produto*/

    /// <summary>
    /// Repositório para manipulação de produtos.
    /// </summary>
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string _connectionString;
        private readonly IConsultaSQL _consultaSQL;
        public string ConnectionString { get; }

        /// <summary>
        /// Inicializa uma nova instância do repositório de produtos.
        /// </summary>
        /// <param name="connectionString">A string de conexão com o banco de dados.</param>
        /// <param name="consultaSQL"> Recupera as consultas SQL do COnsultaSQLResource</param>
        public ProdutoRepository(string connectionString, IConsultaSQL consultaSQL)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _consultaSQL = consultaSQL ?? throw new ArgumentNullException(nameof(consultaSQL));
        }
        /// <summary>
        /// Insere um novo produto no banco de dados.
        /// </summary>
        /// <param name="command">Os detalhes do produto a ser inserido.</param>
        /// <returns>Uma mensagem indicando o resultado da operação.</returns>        
        public async Task<string> PostAsync(ProdutoCommand command)
        {            
            ///<sumary>
            ///Try valida se a conexão com o banco foi bem sucedida
            /// </sumary>
            try
            {
                string queryInserir = _consultaSQL.ObterConsulta("InserirProduto");
                string postEstoque = _consultaSQL.ObterConsulta("InserirEstoqueProduto");                
                string updateCategoria = _consultaSQL.ObterConsulta("AtualizaCategoria");
                string getNumCategoria = _consultaSQL.ObterConsulta("RecuperaCategoria");

                using (SqlConnection conn = new SqlConnection(_connectionString))
                {                    
                        ///<sumary>
                        ///Try valida se as consultas no banco foram bem sucedidas antes de executar a queryInserir
                        /// </sumary>
                        try
                        {
                            // Obtenha o número da categoria
                           
                        // Crie o código do produto usando o número da categoria, marca e cor
                            var codigoProduto = await GeraCodigoProdutoAutomatico(command.marca,command.cor,command.categoria );
                        var numCategoria = conn.Query<int>(getNumCategoria, new { nomeCategoria = command.categoria }).FirstOrDefault();
                            // Execute a inserção na tabela
                            await conn.ExecuteAsync(queryInserir, new
                            {
                                descricao = string.IsNullOrWhiteSpace(command.descricao) ? string.Empty : command.descricao,
                                precoProduto = command.precoProduto,
                                categoria = command.categoria,
                                subCategoria = command.subCategoria,
                                marca = command.marca,
                                cor = command.cor,
                                codigoProduto = codigoProduto

                            });

                            await conn.ExecuteAsync(updateCategoria, new { numCategoria = numCategoria, categoria = command.categoria });
                            await conn.ExecuteAsync(postEstoque, new { codigoProduto = codigoProduto, descricao = command.descricao });
                            
                            return "Produto Cadastrado com sucesso!";
                        }
                        catch (Exception ex)
                        {                                            
                                    
                            throw new Exception("Erro ao cadastrar produto", ex);
                        }
                    }
                
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                throw new Exception("Já existe um produto com o mesmo código.", ex);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new Exception("A categoria, subcategoria, marca ou cor fornecida não existe.", ex);
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados.", ex);
            }
        }
        /// <summary>
        /// Atualiza as informações de um produto existente no banco de dados.
        /// </summary>
        /// <param name="codigoProduto">O código do produto a ser atualizado.</param>
        /// <param name="command">Os novos detalhes do produto.</param>
        /// <returns>Uma mensagem indicando o resultado da operação.</returns>
        public async Task<string> UpdateProdutoAsync(int codigoProduto, ProdutoCommand command)
        {
            string queryAtualiza = _consultaSQL.ObterConsulta("AtualizaProduto");

            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Execute(queryAtualiza, new
                {
                    codigoProduto = codigoProduto,
                    descricao = string.IsNullOrWhiteSpace(command.descricao) ? string.Empty : command.descricao,
                    precoProduto = command.precoProduto,
                    categoria = command.categoria,
                    subCategoria = command.subCategoria,
                    marca = command.marca,
                    cor = command.cor,
                });
            }
            return "Produto Atualizado com sucesso";
        }

        /// <summary>
        /// Retorna uma lista de todos os produtos cadastrados no banco de dados.
        /// </summary>
        /// <returns>Uma lista de produtos.</returns>
        public async Task<IEnumerable<ProdutoCommand>> GetAsyncList()
        {
            string queryLista = _consultaSQL.ObterConsulta("ConsultaProdutoEstoque");

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                return await conn.QueryAsync<ProdutoCommand>(queryLista);
            }
        }

        /// <summary>
        /// Retorna uma lista de produtos com base no código ou descrição fornecidos.
        /// </summary>
        /// <param name="codigoProduto">O código do produto a ser pesquisado.</param>
        /// <param name="descricao">A descrição do produto a ser pesquisado.</param>
        /// <returns>Uma lista de produtos que correspondem aos critérios de pesquisa.</returns>
        public async Task<IEnumerable<ProdutoCommand>> GetAsyncProduto(int codigoProduto, string? descricao)
        {
            string queryProduto = "";
            var parameters = new DynamicParameters();
            if (descricao == null || descricao == "" && codigoProduto != 0)
            {
                queryProduto = _consultaSQL.ObterConsulta("ConsultaProdutoFiltroEstoqueCodigo");
                parameters.Add("@codigoProduto", codigoProduto);
            }
            else if (descricao != null && codigoProduto == 0)
            {
                queryProduto = _consultaSQL.ObterConsulta("ConsultaProdutoFiltroEstoqueDescricao");
                parameters.Add("@descricao","%" + descricao + "%");
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {                
                return await conn.QueryAsync<ProdutoCommand>(queryProduto, parameters) ;
            }
        }

        /// <summary>
        /// Gera um código de produto com base nos IDs de marca, cor e categoria.
        /// </summary>
        /// <param name="marca">O ID da marca do produto.</param>
        /// <param name="cor">O ID da cor do produto.</param>
        /// <param name="categoria">O ID da categoria do produto.</param>
        /// <returns>O código de produto gerado.</returns>
        public async Task<int> GeraCodigoProdutoAutomatico(string marca, string cor, string categoria)
        {
            string getNumCategoria = _consultaSQL.ObterConsulta("RecuperaCategoria");
            string getCategoriaID = _consultaSQL.ObterConsulta("RecuperaIDCategoria");
            string getMarcaID = _consultaSQL.ObterConsulta("RecuperaIDMarca");
            string getCorID = _consultaSQL.ObterConsulta("RecuperaIDCor");
            await using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                int numCategoria;
                int categoriaID;
                int marcaID;
                int corID;
                try 
                {
                    // Obtenha o número da categoria
                   categoriaID = conn.Query<int>(getCategoriaID, new { nomeCategoria = categoria }).FirstOrDefault();
                   numCategoria = conn.Query<int>(getNumCategoria, new { categoriaID = categoriaID }).FirstOrDefault();
                   marcaID = conn.Query<int>(getMarcaID, new {nomeMarca = marca}).FirstOrDefault();
                   corID = conn.Query<int>(getCorID, new { nomeCor = cor }).FirstOrDefault();
                }
                catch(Exception ex) 
                {
                    throw new Exception("Não foi possível encontrar o número da categoria!", ex);
                };

                // Crie o código do produto usando o número da categoria, marca e cor
                var codigoProduto = $"{numCategoria}{marcaID}{corID}";

                return Convert.ToInt32(codigoProduto);
            }
        }
        /// <summary>
        /// Busca informações como o ID e o nome das marcas disponíveis.
        /// </summary>       
        /// <returns> Retorna uma lista das marcas </returns>

        public async Task<IEnumerable<MarcaCommand>> GetMarca()
        {
            string queryGetMarca = _consultaSQL.ObterConsulta("RecuperaMarca");
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    tran.Commit(); 
                    return await conn.QueryAsync<MarcaCommand>(queryGetMarca, transaction: tran);
                }
                catch (SqlException ex)
                {
                    tran.Rollback(); // Revertendo a transação em caso de exceção SQL                   
                    throw new Exception("Erro ao conectar com o banco!",ex);                                                                                          
                }
            }
        }
        /// <summary>
        /// Busca informações como o ID e o nome das cores disponíveis.
        /// </summary>       
        /// <returns> Retorna uma lista das cores </returns>
        public async Task<IEnumerable<CorCommand>> GetCor()
        {
            string queryGetCor = _consultaSQL.ObterConsulta("RecuperaCor");
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    tran.Commit();
                    return await conn.QueryAsync<CorCommand>(queryGetCor, transaction: tran);
                }
                catch (SqlException ex)
                {
                    tran.Rollback(); // Revertendo a transação em caso de exceção SQL                   
                    throw new Exception("Erro ao conectar com o banco!", ex);
                }
            }
        }
        /// <summary>
        /// Busca informações como o ID e o nome das categorias disponíveis.
        /// </summary>       
        /// <returns> Retorna uma lista das categorias </returns>
        public async Task<IEnumerable<CategoriaCommand>> GetCategoria()
        {
            string queryGetCategoria = _consultaSQL.ObterConsulta("RecuperaInfoCategoria");
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    tran.Commit();
                    return await conn.QueryAsync<CategoriaCommand>(queryGetCategoria, transaction: tran);
                }
                catch (SqlException ex)
                {
                    tran.Rollback(); // Revertendo a transação em caso de exceção SQL                   
                    throw new Exception("Erro ao conectar com o banco!", ex);
                }
            }
        }
        /// <summary>
        /// Busca informações como o ID e o nome das subcategorias disponíveis.
        /// </summary>       
        /// <returns> Retorna uma lista das subcategorias </returns>
        public async Task<IEnumerable<SubCategoriaCommand>> GetSubcategoria()
        {
            string queryGetSubCategoria = _consultaSQL.ObterConsulta("RecuperaSubCategoria");
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    tran.Commit();
                    return await conn.QueryAsync<SubCategoriaCommand>(queryGetSubCategoria, transaction: tran);
                }
                catch (SqlException ex)
                {
                    tran.Rollback(); // Revertendo a transação em caso de exceção SQL                   
                    throw new Exception("Erro ao conectar com o banco!", ex);
                }
            }
        }
    }       
}

