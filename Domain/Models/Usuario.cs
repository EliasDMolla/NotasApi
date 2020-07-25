namespace NotasApi.Domain.Models 
{
    public class Usuario 
    {
        public long Id { get; set; }       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public byte[] Contrasenia { get; set; }
        public string Telefono { get; set; }
        public string Documento { get; set; }
    }
}