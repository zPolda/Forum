namespace Forum.Application.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime? DataDeCriacao  { get; set; }

        public DateTime? DataDeModificacao { get; set; }

        public int Vizualizacoes { get; set; }

        public int Likes { get; set; }

        public int Deslikes { get; set; }

        public Usuario Autor { get; set; }

        public List<Categoria> CategoriaPost { get; set; }

        public List<Tag> TagPost { get; set; }

        public List<Comentario> ComentarioPost { get; set; }

    }
}
