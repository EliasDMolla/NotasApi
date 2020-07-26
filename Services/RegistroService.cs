using System.Linq;
using Microsoft.EntityFrameworkCore;
using NotasApi.Domain;
using NotasApi.Domain.Models;

namespace NotasApi.Services
{
    public class RegistroService
    {
        private readonly DataContext _context;

        public RegistroService(DataContext context)
        {
            _context = context;
        }
        public Response<Usuario> Registro(Usuario usuario) 
        {
            IQueryable<Usuario> query = _context.Usuarios;

            var emailExists = query.Any(x => x.Email == usuario.Email);

            if(emailExists) 
                return new Response<Usuario>("Email repetido", true);
            else
                _context.Usuarios.Add(usuario);

                var result = new Response<Usuario>();
                result.Entitites = usuario;
                
            return new Response<Usuario>(usuario);
        }
    }
}