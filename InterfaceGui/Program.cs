using Domain.Interface;
using InterfaceGui;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repository;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Configurar injeção de dependência (usando o container de DI de sua escolha)
        var serviceColection = new ServiceCollection();
        ConfigureServices(serviceColection);
        var serviceProvider = serviceColection.BuildServiceProvider();
                
        // Resolva o serviço necessário
        var produtoService = serviceProvider.GetService<IProdutoService>();

        // Crie o formulário principal e passe a instância do serviço
        Application.Run(new frm_telainicial(produtoService));
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        

        // Registrar serviços necessários
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        // Adicione mais registros de serviços conforme necessário...

        // Construir o provedor de serviços
        
    }


}
