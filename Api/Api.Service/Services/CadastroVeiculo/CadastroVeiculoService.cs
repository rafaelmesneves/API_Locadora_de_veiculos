using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.CadastroVeiculo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services.CadastroVeiculo
{
    public class CadastroVeiculoService : ICadastroVeiculoService
    {
        // Implementação dos métodos da interface ICadastroVeiculoService
        public async Task<CadastroVeiculoEntity> Get(Guid id)
        {
            // Implementação do método Get usando CadastroVeiculoEntity
        }

        public async Task<IEnumerable<CadastroVeiculoEntity>> GetAll()
        {
            // Implementação do método GetAll usando CadastroVeiculoEntity
        }

        public async Task<CadastroVeiculoEntity> Post(CadastroVeiculoEntity veiculo)
        {
            // Implementação do método Post usando CadastroVeiculoEntity
        }

        public async Task<CadastroVeiculoEntity> Put(CadastroVeiculoEntity veiculo)
        {
            // Implementação do método Put usando CadastroVeiculoEntity
        }

        public async Task<bool> Delete(Guid id)
        {
            // Implementação do método Delete
        }
    }
}
