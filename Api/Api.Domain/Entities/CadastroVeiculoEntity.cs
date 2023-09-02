using System;

namespace Api.Domain.Entities
{
    public class CadastroVeiculoEntity : BaseEntity
    {
        public int IdVeiculo { get; set; }
        public string GrupoClassificacao { get; private set; }
        public string IdentificacaoVeiculo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Chassi { get; set; }
        public string Renavan { get; set; }
        public string Foto { get; set; }

        public CadastroVeiculoEntity(string grupoClassificacao)
        {
            GrupoClassificacao = grupoClassificacao;
        }
    }
}
