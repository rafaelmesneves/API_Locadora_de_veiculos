using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface ICadastroVeiculoService
    {
        Task<CadastroVeiculoEntity> Get(int id);
        Task<IEnumerable<CadastroVeiculoEntity>> GetAll();
        Task<CadastroVeiculoEntity> Post(CadastroVeiculoEntity veiculo);
        Task<CadastroVeiculoEntity> Put(CadastroVeiculoEntity veiculo);
        Task<bool> Delete(int id);
    }
}
