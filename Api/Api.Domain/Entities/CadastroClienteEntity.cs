using System;

namespace Api.Domain.Entities
{
    public class CadastroClienteEntity : BaseEntity
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string CNH { get; set; }
        public string Email { get; set; }
        public string SenhaDeAcesso { get; set; }
    }
}
