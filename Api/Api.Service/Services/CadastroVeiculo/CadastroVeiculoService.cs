using Api.Domain.Entities;
using Api.Domain.Interfaces.Services;
using Api.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class CadastroVeiculoService : ICadastroVeiculoService
    {
        private readonly IRepository<CadastroVeiculoEntity> _repository;

        public CadastroVeiculoService(IRepository<CadastroVeiculoEntity> repository)
        {
            _repository = repository;
        }

        public async Task<CadastroVeiculoEntity> Get(Guid id)
