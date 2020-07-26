using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasApi.Domain.Models;
using NotasApi.Services;

namespace NotasApi.Controllers
{
    public class RegistroController : ControllerBase 
    {
        private readonly ILogger<RegistroController> _logger;

        private readonly RegistroService _registroService;

        public RegistroController(ILogger<RegistroController> logger, RegistroService registroService) 
        {
            _logger = logger;
            _registroService = registroService;
        }

        [HttpPost]
        public Response<Usuario> Registro([FromBody] Usuario usuario) 
        {
            var response = new Response<Usuario>();
            try
            {
                response = _registroService.Registro(usuario);

                return response;   
            }
            catch (System.Exception ex)
            {
                response.MsgeError = ex.Message;
                
                return response;
            }
        }
    }
}