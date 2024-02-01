using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ViewModel;
using Dapper;
using Domain.Interface;

namespace Infrastructure.Repository
{
    public class VendasRepository: IVendasRepository
    {
        string conexao = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> PostVendaAsync(VendaViewModel venda)
        {

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string queryVenda = @"INSERT INTO Faturamento(dataEmissao,status_emissao,transacao,documento,serie,
                total,CodPagamento,pagamento,parcelas,CodOperadora,operadora) VAlUES(@data,'Aprovada',1,@documento,@serie,
                @preco,@CodPagamento,@pagamento,@parcelas,@CodOperadora,@operadora)";

                string queryUpdateEstoque = @"UPDATE Estoque 
                SET quantidade=@quantidade,total=@quantidade * @valorUnitario
                WHERE produto=@produto   
                ";



                string queryMovEstoque = @"INSERT INTO MovEstoque(dataMov,tipoMovimento,produto,descricao,documento,valorUnitario,quantidade,total)
                    VALUES (@data,2,@produto,@descricao,@documento,@valorUnitario,@quantidade,@total)";

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
                var verificaQtd = await VerificaQuantidade(venda.quantidade, qtdProduto);


                if (verificaQtd == false)
                {
                    return $"Quantidade Indisponível, há apenas {qtdProduto}.";
                }
                object value = conn.Query(queryVenda, new
                {

                    data = venda.data,
                    transacao = 1,
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

                conn.Query(queryMovEstoque, new
                {
                    data = venda.data,
                    produto = venda.produto.produto,
                    descricao = descricaoProduto,
                    documento = venda.documento,
                    valorUnitario = valorUnitario,
                    quantidade = venda.quantidade,
                    total = total

                });

                return "Venda realizada com sucesso!";

            }
        }

        public async Task<bool> VerificaQuantidade(int qtdInserida, int qtdDisponivel)
        {
            if (qtdInserida > qtdDisponivel)
            {
                return false;
            }

            return true;
        }
    }
}
