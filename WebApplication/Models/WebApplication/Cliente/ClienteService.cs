using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Data;
using Microsoft.EntityFrameworkCore;
namespace WebApplication.Models.WebApplication.Cliente
{
    public class ClienteService
    {
        private readonly DataBaseContext _databaseContext;

        public ClienteService(
            DataBaseContext databaseContext
        )
        {
            _databaseContext = databaseContext;
        }

        public List<ClienteEntity> ObterClientesComFiltro(string filtroNome, string filtroEmail, bool apenascomEventos)
        {
            var listaClientes = DataBaseContext.Clientes
                .Include(navigationPropertyPath:c:ClienteEntity=>c.Eventos)
                .AsQueryable();

            if (filtroNome != null)
            {
                listaClientes = listaClientes.Where(c: ClienteEntity => c.filtroNome.Contains(filtroNome));
            }
            if (filtroEmail != null)
            {
                listaClientes = listaClientes.Where(c: ClienteEntity => c.filtroEmail.Contains(filtroEmail));
            }
            if (apenascomEventos != null)
            {
                listaClientes = listaClientes.Where(c: ClienteEntity => c.Eventos.Count>0);
            }

            return listaClientes.ToList();
        }
    }
    }