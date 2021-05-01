using System;
using WebApplication.Models.WebApplication.Evento;

namespace WebApplication.Models.WebApplication.Convidado
{
    public class ConvidadoEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int CPF { get; set; }
        public DateTime Datanascimento { get; set; }
        public EventoEntity Evento { get; set; }
        public SituacaoConvidado SituacaoConvidado { get; set; }
        public string Observacao { get; set; }
        public DateTime Inserido { get; set; }
        public DateTime UltimaModificacao { get; set; }
    }
}