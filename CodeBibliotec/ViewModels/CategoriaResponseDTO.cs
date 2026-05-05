namespace CodeBibliotec.ViewModels
{
    public class CategoriaResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<string> IdLivros { get; set; } = new List<string>();

    }
}
