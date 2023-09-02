using System;

namespace Api.Domain.Entities
{
    public class CadastroFuncionarioEntity : BaseEntity
    {
        public int IdFuncionario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
