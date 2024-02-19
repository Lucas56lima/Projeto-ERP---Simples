using Domain.Interface;
using InterfaceGui;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repository;
using Infrastructure.Queries;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Configurar inje��o de depend�ncia (usando o container de DI de sua escolha)
        var serviceColection = new ServiceCollection();
        ConfigureServices(serviceColection);
        var serviceProvider = serviceColection.BuildServiceProvider();
                
        // Resolva o servi�o necess�rio
        var produtoService = serviceProvider.GetService<IProdutoService>();

        // Crie o formul�rio principal e passe a inst�ncia do servi�o
        Application.Run(new frm_telainicial(produtoService));
    }

    private static void ConfigureServices(IServiceCollection services)
    {      
        // Registrar servi�os necess�rios
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IConsultaSQL, ConsultaSQL> ();
        string connectionString = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";
        services.AddSingleton(connectionString);
        ConsultaSQL consultaSQL = new ConsultaSQL();
        // Adicione mais registros de servi�os conforme necess�rio...

        // Construir o provedor de servi�os

    }


}
