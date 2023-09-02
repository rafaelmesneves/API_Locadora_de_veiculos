using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.CadastroCliente;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.CadastroCliente
{
    public class CadastroClienteService : ICadastroClienteService
    {
        // Implementação dos métodos da interface ICadastroClienteService
        public async Task<CadastroClienteEntity> Get(Guid id)
        {
            // Implementação do método Get usando CadastroClienteEntity
        }

        public async Task<IEnumerable<CadastroClienteEntity>> GetAll()
        {
            // Implementação do método GetAll usando CadastroClienteEntity
        }

        public async Task<CadastroClienteEntity> Post(CadastroClienteEntity cliente)
        {
            // Implementação do método Post usando CadastroClienteEntity
        }

        public async Task<CadastroClienteEntity> Put(CadastroClienteEntity cliente)
        {
            // Implementação do método Put usando CadastroClienteEntity
        }

        public async Task<bool> Delete(Guid id)
        {
            // Implementação do método Delete
        }
    }
}
