using Api.Domain.Entities;
using System;

namespace Api.Domain.Entities
{
    public class CadastroVeiculoEntity : BaseEntity
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        // Outras propriedades específicas de veículo, se houver
    }
}
