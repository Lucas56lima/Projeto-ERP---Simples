using System.Data.SqlClient;
using Domain.Commands;
using Domain.Interface;
using Dapper;
using Domain.ViewModel;
using Domain.Entidades;

namespace Infrastructure.Repository
{
    /* Inclusão do cadastro de produto*/
    public class ProdutoRepository: IProdutoRepository
    {
        string conexao = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostAsync(ProdutoCommand command)
        {
            
            string queryInsert = @"
            INSERT INTO CadastroProduto (codigoProduto,descricao,precoProduto,categoria,subCategoria,marca,cor) VALUES
            (@codigoProduto,UPPER(@descricao),@precoProduto,@categoria,@subCategoria,@marca,@cor)
            ";
            string getNumCategoria =  @"SELECT numero FROM CadCategoria WHERE categoriaID=@categoria";
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
                
                var queryAtualiza = conn.Query(updateCategoria, new
                {
                    numCategoria = numCategoria,
                    categoria = (int)command.categoria
                });

                var queryCriaEstoque = conn.Query(postEstoque, new
                {
                    codigoProduto = codigoProduto,
                    descricao = command.descricao
                }); 
            }

            return "Produto Cadastrado com sucesso!";
        }

        public async Task<string>PostVendaAsync(VendaViewModel venda)
        {

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string queryVenda = @"INSERT INTO Faturamento(dataEmissao,status_emissao,transacao,documento,serie,
                total,CodPagamento,pagamento,parcelas,CodOperadora,operadora) VAlUES(@data,'Aprovada',1,@documento,@serie,
                @quantidade * @preco,@CodPagamento,@pagamento,@parcelas,@CodOperadora,@operadora)";

                string queryUpdateEstoque = @"UPDATE Estoque 
                SET quantidade=@quantidade,total=@quantidade * @valorUnitario
                WHERE produto=@produto   
                ";

                string getQuantidade = "SELECT quantidade FROM Estoque WHERE produto = @produto";
                string getDescricao = "SELECT descricao FROM Estoque WHERE produto = @produto";
                string getPreco = "SELECT precoProduto FROM CadastroProduto WHERE codigoProduto = @produto";
                string getPagamento = "SELECT nomePagamento FROM CadPagamento WHERE pagamentoID= @Codpagamento";
                string getTransacao = "SELECT nomeTransacoes FROM Cadtransacoes WHERE transacoesID= @Codtransacao";
                string getOperadora = "SELECT nomeOperadora FROM CadOperadora WHERE operadoraID= @Codoperadora";
                string getValorUnitario = "SELECT valorUnitario FROM Estoque WHERE produto = @produto";

                var qtdProduto = conn.Query<int>(getQuantidade, new { produto = venda.produto.produto }).FirstOrDefault();
                var precoProduto = conn.Query<decimal>(getPreco, new { produto = venda.produto.produto }).FirstOrDefault();
                var descricaoProduto = conn.Query<string>(getDescricao, new { produto = venda.produto.produto }).FirstOrDefault();

                var pagamento = conn.Query<string>(getPagamento, new { CodPagamento = venda.CodPagamento }).FirstOrDefault();
                var transacao = conn.Query<string>(getTransacao, new { CodTransacao = venda.CodTransacao }).FirstOrDefault();
                var operadora = conn.Query<string>(getOperadora, new { CodOperadora = venda.CodOperadora }).FirstOrDefault();

                var quantidade = qtdProduto - venda.quantidade;

                var total = precoProduto * venda.quantidade;
                var valorUnitario = conn.Query<decimal>(getValorUnitario, new { produto = venda.produto.produto }).FirstOrDefault();

                 conn.Query(queryVenda, new
                {

                    data = venda.data,                    
                    transacao = venda.CodTransacao,
                    quantidade = venda.quantidade,
                    documento = venda.documento,
                    serie = venda.serie,                    
                    preco = total,
                    CodPagamento = (int)venda.CodPagamento,
                    pagamento = pagamento,
                    parcelas = 1,
                    CodOperadora = (int)venda.CodOperadora,
                    operadora = operadora,                    
                });

                conn.Query(queryUpdateEstoque, new
                {
                    produto = venda.produto.produto,
                    quantidade = quantidade,
                    valorUnitario = valorUnitario

                });

                return "Venda realizada com sucesso!";

             }  
        }

        public async Task<string> PutEstoqueAsync(EstoqueCommand estoque)
        {
           
            using(SqlConnection conn = new SqlConnection(conexao))
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
               
                conn.Query(queryUpdateEstoque, new EstoqueCommand
                {
                    quantidade = qtdProduto + estoque.quantidade,
                    valorUnitario = (vlrUniProduto + estoque.valorUnitario)/2,
                    produto = estoque.produto
                });

                return "Estoque atualizado";

            }
        }
    }
}
