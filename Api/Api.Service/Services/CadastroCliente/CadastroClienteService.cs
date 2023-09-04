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

        }

        public async Task<IEnumerable<CadastroClienteEntity>> GetAll()
        {

        }

        public async Task<CadastroClienteEntity> Post(CadastroClienteEntity cliente)
        {

        }

        public async Task<CadastroClienteEntity> Put(CadastroClienteEntity cliente)
        {

        }

        public async Task<bool> Delete(Guid id)
        {

        }
    }
}
