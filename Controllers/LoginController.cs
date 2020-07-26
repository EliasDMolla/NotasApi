using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotasApi.Domain.Models;
using NotasApi.Services;
using System;

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
        public Response<Usuario> Login([FromBody] Usuario usuario)
        {
            var response = new Response<Usuario>();
            try
            {
                response = _loginService.ValidarLogin(usuario);

                return response;
            }
            catch (Exception ex)
            {
                response.MsgeError = ex.Message;

                return response;
            }
        }
    } 
}