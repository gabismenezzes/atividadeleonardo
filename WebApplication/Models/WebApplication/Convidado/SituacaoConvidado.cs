using System;

namespace WebApplication.Models.WebApplication.Convidado
{
    public class SituacaoConvidado
    {
        public class SituacaoEventoEntity
        {
            public int Id { get; set; }
            public Boolean Confirmado{ get; set; }
            public Boolean Cancelado{ get; set; }
            public Boolean EmDuvida{ get; set; }
            public Boolean DemaisOutros{ get; set; } 
        }
    }
}