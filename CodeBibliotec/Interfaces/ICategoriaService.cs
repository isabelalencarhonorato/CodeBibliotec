using CodeBibliotec.ViewModels;

namespace CodeBibliotec.Interfaces
{
    public interface ICategoriaService
    {

        Task<CategoriaResponseDTO> CadastrarCategoriaAsync(CategoriaViewModel categoriaViewModel);
        Task<List<CategoriaResponseDTO>> ObterTodasCategoriasAsync();
        Task<CategoriaResponseDTO> ObterCategoriaPorIdAsync(int id);
    }

}
