namespace Forum.Application.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Post PostRelacionadoTag { get; set; }
    }
}
