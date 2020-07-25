using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasApi.Domain.Models;
using NotasApi.Services;

namespace NotasApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class LoginController : ControllerBase 
    {
        private readonly ILogger<LoginController> _logger;
        private readonly LoginService _loginService;

        public LoginController(ILogger<LoginController> logger, LoginService loginService) 
        {
            _logger = logger;
            _loginService = loginService;
        }

        [HttpPost]
        public Usuario Login([FromBody] Usuario usuario)
        {
            try
            {
                var response = _loginService.ValidarLogin(usuario);

                return response;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    } 
}