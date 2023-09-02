using Api.Domain.Entities;
using System;

namespace Api.Domain.Entities
{
    public class CadastroClienteEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        // Outras propriedades específicas de cliente, se houver
    }
}
