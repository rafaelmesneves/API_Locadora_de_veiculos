using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.CadastroFuncionario;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.CadastroFuncionario
{
    public class CadastroFuncionarioService : ICadastroFuncionarioService
    {
        // Implementação dos métodos da interface ICadastroFuncionarioService
        public async Task<CadastroFuncionarioEntity> Get(Guid id)
        {
            // Implementação do método Get usando CadastroFuncionarioEntity
        }

        public async Task<IEnumerable<CadastroFuncionarioEntity>> GetAll()
        {
            // Implementação do método GetAll usando CadastroFuncionarioEntity
        }

        public async Task<CadastroFuncionarioEntity> Post(CadastroFuncionarioEntity funcionario)
        {
            // Implementação do método Post usando CadastroFuncionarioEntity
        }

        public async Task<CadastroFuncionarioEntity> Put(CadastroFuncionarioEntity funcionario)
        {
            // Implementação do método Put usando CadastroFuncionarioEntity
        }

        public async Task<bool> Delete(Guid id)
        {
            // Implementação do método Delete
        }
    }
}
