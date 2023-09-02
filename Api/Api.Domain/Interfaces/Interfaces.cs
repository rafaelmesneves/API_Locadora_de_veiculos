using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<CadastroClienteEntity> Get(Guid id);
        Task<IEnumerable<CadastroClienteEntity>> GetAll();
        Task<CadastroClienteEntity> Post(CadastroClienteEntity user);
        Task<CadastroClienteEntity> Put(CadastroClienteEntity user);
        Task<bool> Delete(Guid id);
    }
}
