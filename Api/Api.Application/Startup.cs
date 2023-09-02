using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Api.Application.Services.CadastroCliente; // Corrija o namespace para apontar para o local correto
using Api.Application.Services.CadastroFuncionario; // Corrija o namespace para apontar para o local correto
using Api.Application.Services.CadastroVeiculo; // Corrija o namespace para apontar para o local correto
using Api.Domain.Entities.CadastroCliente; // Corrija o namespace para apontar para o local correto
using Api.Domain.Entities.CadastroFuncionario; // Corrija o namespace para apontar para o local correto
using Api.Domain.Entities.CadastroVeiculo; // Corrija o namespace para apontar para o local correto
using Api.Domain.Interfaces.Repositories; // Corrija o namespace para apontar para o local correto

public void ConfigureServices(IServiceCollection services)
{
    // ... Outras configurações

    // Configurações para a tabela CadastroCliente
    services.AddScoped<ICadastroClienteService, CadastroClienteService>();
    services.AddScoped<IRepository<CadastroClienteEntity>, BaseRepository<CadastroClienteEntity>>();

    // Configurações para a tabela CadastroFuncionario
    services.AddScoped<ICadastroFuncionarioService, CadastroFuncionarioService>();
    services.AddScoped<IRepository<CadastroFuncionarioEntity>, BaseRepository<CadastroFuncionarioEntity>>();

    // Configurações para a tabela CadastroVeiculo
    services.AddScoped<ICadastroVeiculoService, CadastroVeiculoService>();
    services.AddScoped<IRepository<CadastroVeiculoEntity>, BaseRepository<CadastroVeiculoEntity>>();

    // Configuração do Swagger (opcional)
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Locadora de Veículos", Version = "v1" });
    });

    // ... Outras configurações
}
