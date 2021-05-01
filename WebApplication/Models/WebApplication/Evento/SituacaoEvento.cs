using System;

namespace WebApplication.Models.WebApplication.Evento
{
    public class SituacaoEvento
    {
        public class SituacaoEventoEntity
        {
            public int Id { get; set; }
            public Boolean Agendado{ get; set; }    
            public Boolean Cancelado{ get; set; }     
            public Boolean Executado{ get; set; }      
            public Boolean DemaisOutros{ get; set; }  
        }
    }
}