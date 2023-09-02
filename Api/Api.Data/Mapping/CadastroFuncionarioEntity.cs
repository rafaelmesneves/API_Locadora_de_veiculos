using Api.Domain.Entities;
using System;

namespace Api.Domain.Entities
{
    public class CadastroFuncionarioEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }
        // Outras propriedades específicas de funcionário, se houver
    }
}
