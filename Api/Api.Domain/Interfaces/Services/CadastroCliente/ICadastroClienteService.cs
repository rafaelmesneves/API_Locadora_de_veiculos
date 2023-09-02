using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.CadastroCliente
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
