using Microsoft.AspNetCore.Mvc;
using WebApplication.RequestModels.Buffet;
using WebApplication.Views.Home;

namespace WebApplication.Controllers.Admin
{
    public class SecaoTesteController
    {
        public IActionResult Index(FiltroListagemClientes request)
        {
            var viewmodel = new IndexViewModel()
            {
                FormMensagemSucesso = (string) TempData["formMensagemSucesso"],
                FormMensagemErro = (string[]) TempData["formMensagensErro"]
            };
        var filtroNome = request.Nome;
        var filtroEmail = request.Email;
        var filtroApenascomeventos = request.Apenascomeventos;
        }
    }
}