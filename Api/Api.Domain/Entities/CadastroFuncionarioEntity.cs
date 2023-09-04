
using System;
using System.ComponentModel.DataAnnotations;

namespace SuaApp.Domain.Entities
{
    public class CadastroFuncionarioEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo CPF deve conter 11 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo Cargo é obrigatório.")]
        public string Cargo { get; set; }
    }
}
