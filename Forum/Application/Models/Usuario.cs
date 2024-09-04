namespace Forum.Application.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomeDeUsuario { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime? DataDeRegistro { get; set; }

        public string Biografia { get; set; }
    }
}
