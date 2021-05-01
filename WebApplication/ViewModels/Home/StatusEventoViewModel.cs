using System.Collections.Generic;
using WebApplication.ViewModels.Shared;

namespace WebApplication.ViewModels.Home
{
    public class StatusEventoViewModel
    {
        public List<Status> ListaDeStatus { get; set; }

        public StatusEventoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }
    }
}