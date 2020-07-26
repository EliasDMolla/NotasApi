using Microsoft.EntityFrameworkCore;
using NotasApi.Domain.Models;
using NotasApi.Domain;
using System.Linq;

namespace NotasApi.Services
{
    public class LoginService
    {
        private readonly DataContext _context;
        public LoginService(DataContext context)
        {
            _context = context;
        }
        public Usuario ValidarLogin(Usuario entity) 
        {
            var user = new Usuario();
            user = _context.Usuarios.Where(x => x.Email == entity.Email && x.Contrasenia == entity.Contrasenia).FirstOrDefault();

            return user;
        }
    }
}