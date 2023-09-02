using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.CadastroFuncionario
{
    public interface ICadastroFuncionarioService
    {
        Task<CadastroFuncionarioEntity> Get(Guid id);
        Task<IEnumerable<CadastroFuncionarioEntity>> GetAll();
        Task<CadastroFuncionarioEntity> Post(CadastroFuncionarioEntity funcionario);
        Task<CadastroFuncionarioEntity> Put(CadastroFuncionarioEntity funcionario);
        Task<bool> Delete(Guid id);
    }
}
