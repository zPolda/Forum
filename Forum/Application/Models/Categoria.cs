namespace Forum.Application.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public int Descricao { get; set; } 

        public Post PostRelacionadoCategoria { get; set; }
    }
}
