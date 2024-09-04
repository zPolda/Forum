namespace Forum.Application.Models
{
    public class Comentario
    {
        public int Id { get; set; }

        public string Conteudo { get; set; }

        public DateTime? DataDeCriação { get; set; }

        public int Likes { get; set; }

        public int Deslikes { get; set; }

        public Post PostRelacionado { get; set; }

        public Usuario AutorComentario { get; set; }

    }
}
