using Microsoft.EntityFrameworkCore;
using NotasApi.Domain.Models;

namespace NotasApi.Domain 
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Usuario> Usuarios {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //Usuario
            modelBuilder.Entity<Usuario>().HasKey(f => f.Id);
            modelBuilder.Entity<Usuario>().Property(f => f.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuario>().Property(f => f.Nombre).IsRequired();
            modelBuilder.Entity<Usuario>().Property(f => f.Apellido).IsRequired();
            modelBuilder.Entity<Usuario>().Property(f => f.Email).IsRequired();
            modelBuilder.Entity<Usuario>().Property(f => f.Contrasenia).IsRequired();
            modelBuilder.Entity<Usuario>().Property(f => f.Telefono).IsRequired();
        }
    }
}