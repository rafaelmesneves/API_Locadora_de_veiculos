using Microsoft.Extensions.DependencyInjection;
using Api.Domain.Interfaces.Services;
using Api.CrossCutting.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Api.Domain.Interfaces.Repositories;
using Api.Data.Repositories;

internal partial class Program
{
    private static void Main(string[] args)
    {
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        _ = services.AddScoped<Api.Service.Services.CadastroClienteService, Api.Service.Services.CadastroClienteService>();
        services.AddScoped<IRepository<Api.Domain.Entities.CadastroClienteEntity>, Repository<Api.Domain.Entities.CadastroClienteEntity>>();

        services.AddScoped<ICadastroClienteService, CadastroClienteService>();
        services.AddScoped<IRepository<CadastroClienteEntity>, Repository<CadastroClienteEntity>>();

        services.AddScoped<ICadastroFuncionarioService, CadastroFuncionarioService>();
        services.AddScoped<IRepository<CadastroFuncionarioEntity>, Repository<CadastroFuncionarioEntity>>();

        services.AddScoped<ICadastroVeiculoService, CadastroVeiculoService>();
        services.AddScoped<IRepository<CadastroVeiculoEntity>, Repository<CadastroVeiculoEntity>>();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Locadora de Veículos", Version = "v1" });
        });


    }
}

internal class OpenApiInfo : Info
{
    public string Title { get; set; }
    public string Version { get; set; }
}
