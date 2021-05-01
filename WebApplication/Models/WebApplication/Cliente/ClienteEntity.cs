using System;
using System.Collections;
using System.Collections.Generic;
using WebApplication.Models.WebApplication.Evento;
namespace WebApplication.Models.WebApplication.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
            public string Observacoes { get; set; }
            public DateTime Inserido { get; set; }
            public DateTime UltimaModificacao { get; set; }
            public TipoCliente TipoCliente { get; set; }
            public int Cpf { get; set; }
            public int Cnpj { get; set; }
            public DateTime DataNasimento { get; set; }
            
            public ICollection<EventoEntity> Eventos { get; set; }

            public ClienteEntity()
            {
                Id = new Guid();
                Eventos = new List<EventoEntity>();
            }
        }
    }