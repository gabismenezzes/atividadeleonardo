using System.Collections.Generic;
using WebApplication.ViewModels.Shared;
namespace WebApplication.ViewModels.Home
{
    public class StatusConvidadoViewModel
    {
        public List<Status> ListaDeStatus { get; set; }

        public StatusConvidadoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }
    }
}