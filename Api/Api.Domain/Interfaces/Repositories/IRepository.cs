using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Repositories;
using Api.Domain.Entities;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Domain.Interfaces.Repositories
{
    {
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> RemoveAsync(Guid id);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<CadastroClienteService, CadastroClienteService>();
        services.AddScoped<IRepository<CadastroClienteEntity>, Repository<CadastroClienteEntity>>();

    }
}
