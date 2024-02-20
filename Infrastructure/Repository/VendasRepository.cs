﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ViewModel;
using Dapper;
using Domain.Interface;
using Domain.Commands;

namespace Infrastructure.Repository
{
    public class VendasRepository: IVendasRepository
    {
        private readonly string _connectionString;
        private readonly IConsultaSQL _consultaSQL;
        public string ConnectionString { get; }

        /// <summary>
        /// Inicializa uma nova instância do repositório de produtos.
        /// </summary>
        /// <param name="connectionString">A string de conexão com o banco de dados.</param>
        /// <param name="consultaSQL"> Recupera as consultas SQL do COnsultaSQLResource</param>

        public VendasRepository(string connectionString, IConsultaSQL consultaSQL)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
            _consultaSQL = consultaSQL ?? throw new ArgumentNullException(nameof(consultaSQL));
        }
        public async Task<string> PostVendaAsync(VendaViewModel venda)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string queryVenda = _consultaSQL.ObterConsulta("InserirVenda");
                string queryUpdateEstoque = _consultaSQL.ObterConsulta("AtualizaEstoque");
                string queryMovEstoque = _consultaSQL.ObterConsulta("InserirMovEstoque");
                string informacoesEstoque = _consultaSQL.ObterConsulta("RecuperarInformacoesEstoque");
                string informacoesProduto = _consultaSQL.ObterConsulta("RecuperaPrecoProduto");
                var produtoInfo = await conn.QueryFirstOrDefaultAsync<ProdutoInfoCommand>(informacoesEstoque, new { produto = venda.Produto });              
                
                if (produtoInfo == null)
                {                    
                    throw new Exception("Produto não existe");
                }

                var parametros = new DynamicParameters();                                                                                                     
                var pagamento = conn.Query<string>(getPagamento, new { CodPagamento = venda.CodPagamento }).FirstOrDefault();
                var transacao = conn.Query<string>(getTransacao, new { CodTransacao = venda.CodTransacao }).FirstOrDefault();
                var operadora = conn.Query<string>(getOperadora, new { CodOperadora = venda.CodOperadora }).FirstOrDefault();

                var quantidade = produtoInfo.Quantidade - venda.quantidade;

                var total = produtoInfo.PrecoProduto * venda.quantidade;                
                var verificaQtd = await VerificaQuantidade(venda.quantidade, produtoInfo.Quantidade);
                if (verificaQtd == true)
                {
                    return $"Quantidade Indisponível, há apenas {produtoInfo.Quantidade}.";
                }
                conn.Query(queryVenda, new
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
                    produto = venda.Produto,
                    quantidade = quantidade,
                    valorUnitario = produtoInfo.ValorUnitario
                });

                conn.Query(queryMovEstoque, new
                {
                    data = venda.data,
                    produto = venda.Produto,
                    descricao = produtoInfo.Descricao,
                    documento = venda.documento,
                    valorUnitario = produtoInfo.ValorUnitario,
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
                return true;
            }

            return false;
        }
    }
}
