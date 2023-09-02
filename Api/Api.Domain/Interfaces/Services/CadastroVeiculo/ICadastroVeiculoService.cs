using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Domain.Interfaces.Services.CadastroVeiculo
{
    public interface ICadastroVeiculoService
    {
        Task<CadastroVeiculoEntity> Get(Guid id);
        Task<IEnumerable<CadastroVeiculoEntity>> GetAll();
        Task<CadastroVeiculoEntity> Post(CadastroVeiculoEntity veiculo);
        Task<CadastroVeiculoEntity> Put(CadastroVeiculoEntity veiculo);
        Task<bool> Delete(Guid id);
    }
}
