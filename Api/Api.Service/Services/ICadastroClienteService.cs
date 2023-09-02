using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface ICadastroClienteService
    {
        Task<CadastroClienteEntity> Get(Guid id);
        Task<IEnumerable<CadastroClienteEntity>> GetAll();
        Task<CadastroClienteEntity> Post(CadastroClienteEntity cliente);
        Task<CadastroClienteEntity> Put(CadastroClienteEntity cliente);
        Task<bool> Delete(Guid id);
    }
}
