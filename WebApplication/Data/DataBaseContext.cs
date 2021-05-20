using System;
using Microsoft.EntityFrameworkCore;
using WebApplication.Views.Acesso;
using WebApplication.Models.WebApplication.Cliente;
using WebApplication.Models.WebApplication.Evento;
using WebApplication.Models.Acesso;
using static Microsoft.EntityFrameworkCore.DbContext;

namespace WebApplication.Data
{
    public class DataBaseContext : IdentityDbContext<Usuario, Papel, Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<EventoEntity> Eventos { get; set; }

        public DataBaseContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }
    }
}