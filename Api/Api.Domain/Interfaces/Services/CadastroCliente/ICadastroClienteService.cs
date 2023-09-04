using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Api.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class CadastroClienteService : ICadastroClienteService
    {
        private readonly IRepository<CadastroClienteEntity> _repository;

        public CadastroClienteService(IRepository<CadastroClienteEntity> repository)
        {
            _repository = repository;
        }

        public async Task<CadastroClienteEntity> Get(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<CadastroClienteEntity>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CadastroClienteEntity> Post(CadastroClienteEntity cliente)
        {
            // Implemente a lógica de criação do cliente aqui e retorne o cliente criado.
        }

        public async Task<CadastroClienteEntity> Put(CadastroClienteEntity cliente)
        {
            // Implemente a lógica de atualização do cliente aqui e retorne o cliente atualizado.
        }

        public async Task<bool> Delete(Guid id)
        {
            // Implemente a lógica de exclusão do cliente aqui e retorne true se for bem-sucedida.
        }
    }
}
