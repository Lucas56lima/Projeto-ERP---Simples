﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Queries {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConsultaSQLResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConsultaSQLResource() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Infrastructure.Queries.ConsultaSQLResource", typeof(ConsultaSQLResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a UPDATE CadCategoria SET numero=@numCategoria + 1 WHERE categoriaID=@categoria.
        /// </summary>
        internal static string AtualizaCategoria {
            get {
                return ResourceManager.GetString("AtualizaCategoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a UPDATE Estoque  SET quantidade=@quantidade,valorUnitario=@valorUnitario,total=@quantidade * @valorUnitario WHERE produto=@produto.
        /// </summary>
        internal static string AtualizaEstoque {
            get {
                return ResourceManager.GetString("AtualizaEstoque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a UPDATE CadastroProduto SET descricao = UPPER(@descricao),precoProduto = @precoProduto,categoria = @categoria,
        ///subCategoria = @subCategoria,marca = @marca,cor = @cor WHERE codigoProduto = @codigoProduto.
        /// </summary>
        internal static string AtualizaProduto {
            get {
                return ResourceManager.GetString("AtualizaProduto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT CadastroProduto.*, quantidade 
        ///FROM CadastroProduto 
        ///INNER JOIN Estoque ON CadastroProduto.codigoProduto = Estoque.produto.
        /// </summary>
        internal static string ConsultaProdutoEstoque {
            get {
                return ResourceManager.GetString("ConsultaProdutoEstoque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT CadastroProduto.*, quantidade 
        ///FROM CadastroProduto 
        ///INNER JOIN Estoque ON CadastroProduto.codigoProduto = Estoque.produto WHERE CadastroProduto.codigoProduto = @codigoProduto.
        /// </summary>
        internal static string ConsultaProdutoFiltroEstoqueCodigo {
            get {
                return ResourceManager.GetString("ConsultaProdutoFiltroEstoqueCodigo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT CadastroProduto.*, quantidade 
        ///FROM CadastroProduto 
        ///INNER JOIN Estoque ON CadastroProduto.codigoProduto = Estoque.produto WHERE CadastroProduto.descricao LIKE @descricao.
        /// </summary>
        internal static string ConsultaProdutoFiltroEstoqueDescricao {
            get {
                return ResourceManager.GetString("ConsultaProdutoFiltroEstoqueDescricao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a INSERT INTO Estoque (produto,descricao) VALUES(@codigoProduto,UPPER(@descricao)).
        /// </summary>
        internal static string InserirEstoqueProduto {
            get {
                return ResourceManager.GetString("InserirEstoqueProduto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a INSERT INTO MovEstoque(dataMov,tipoMovimento,produto,descricao,documento,valorUnitario,quantidade,total)
        ///                    VALUES (@data,2,@produto,@descricao,@documento,@valorUnitario,@quantidade,@total).
        /// </summary>
        internal static string InserirMovEstoque {
            get {
                return ResourceManager.GetString("InserirMovEstoque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a INSERT INTO CadastroProduto (codigoProduto,descricao,precoProduto,categoria,subCategoria,marca,cor) VALUES
        ///(@codigoProduto,UPPER(@descricao),@precoProduto,@categoria,@subCategoria,@marca,@cor).
        /// </summary>
        internal static string InserirProduto {
            get {
                return ResourceManager.GetString("InserirProduto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a INSERT INTO Faturamento(dataEmissao,status_emissao,transacao,documento,serie,
        ///                total,CodPagamento,pagamento,parcelas,CodOperadora,operadora) VAlUES(@data,&apos;Aprovada&apos;,1,@documento,@serie,
        ///                @preco,@CodPagamento,@pagamento,@parcelas,@CodOperadora,@operadora).
        /// </summary>
        internal static string InserirVenda {
            get {
                return ResourceManager.GetString("InserirVenda", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT numero FROM CadCategoria WHERE categoriaID=@categoriaID.
        /// </summary>
        internal static string RecuperaCategoria {
            get {
                return ResourceManager.GetString("RecuperaCategoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT * FROM CadCor.
        /// </summary>
        internal static string RecuperaCor {
            get {
                return ResourceManager.GetString("RecuperaCor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT categoriaID FROM CadCor WHERE nomeCategoria = @nomeCategoria.
        /// </summary>
        internal static string RecuperaIDCategoria {
            get {
                return ResourceManager.GetString("RecuperaIDCategoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT corID FROM CadCor WHERE nomeCor = @nomeCor.
        /// </summary>
        internal static string RecuperaIDCor {
            get {
                return ResourceManager.GetString("RecuperaIDCor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT marcaID FROM CadMarca WHERE nomeMarca = @nomeMarca.
        /// </summary>
        internal static string RecuperaIDMarca {
            get {
                return ResourceManager.GetString("RecuperaIDMarca", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT * FROM CadCategoria.
        /// </summary>
        internal static string RecuperaInfoCategoria {
            get {
                return ResourceManager.GetString("RecuperaInfoCategoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT Estoque.descricao,Estoque.quantidade,Estoque.valorUnitario, precoProduto 
        ///FROM CadastroProduto 
        ///INNER JOIN Estoque ON CadastroProduto.codigoProduto = Estoque.produto WHERE CadastroProduto.codigoProduto = @codigoProduto.
        /// </summary>
        internal static string RecuperaInformacoesEstoque {
            get {
                return ResourceManager.GetString("RecuperaInformacoesEstoque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT * FROM CadMarca.
        /// </summary>
        internal static string RecuperaMarca {
            get {
                return ResourceManager.GetString("RecuperaMarca", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT nomeOperadora FROM CadOperadora WHERE operadoraID= @Codoperadora.
        /// </summary>
        internal static string RecuperaOperadoraCartao {
            get {
                return ResourceManager.GetString("RecuperaOperadoraCartao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT precoProduto FROM CadastroProduto WHERE codigoProduto = @produto.
        /// </summary>
        internal static string RecuperaPrecoProduto {
            get {
                return ResourceManager.GetString("RecuperaPrecoProduto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT * FROM CadSubCategoria.
        /// </summary>
        internal static string RecuperaSubCategoria {
            get {
                return ResourceManager.GetString("RecuperaSubCategoria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT nomePagamento FROM CadPagamento WHERE pagamentoID= @Codpagamento.
        /// </summary>
        internal static string RecuperaTipoPagamento {
            get {
                return ResourceManager.GetString("RecuperaTipoPagamento", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a SELECT nomeTransacoes FROM Cadtransacoes WHERE transacoesID= @Codtransacao.
        /// </summary>
        internal static string RecuperaTipoTransacao {
            get {
                return ResourceManager.GetString("RecuperaTipoTransacao", resourceCulture);
            }
        }
    }
}
