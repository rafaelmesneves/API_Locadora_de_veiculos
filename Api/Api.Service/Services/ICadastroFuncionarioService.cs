using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface ICadastroFuncionarioService
    {
        Task<CadastroFuncionarioEntity> Get(int id);
        Task<IEnumerable<CadastroFuncionarioEntity>> GetAll();
        Task<CadastroFuncionarioEntity> Post(CadastroFuncionarioEntity funcionario);
        Task<CadastroFuncionarioEntity> Put(CadastroFuncionarioEntity funcionario);
        Task<bool> Delete(int id);
    }
}
