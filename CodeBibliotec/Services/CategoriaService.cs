using CodeBibliotec.Domains;
using CodeBibliotec.Interfaces;
using CodeBibliotec.ViewModels;

namespace CodeBibliotec.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        //

        public async Task<CategoriaResponseDTO> CadastrarCategoriaAsync(CategoriaViewModel categoriaViewModel)
        {

        var categoria = new Categorium
        {
            Nome = categoriaViewModel.Nome
        };  

            var response = await _categoriaRepository.CadastrarCategoriaAsync(categoria);
            return MapToCategoriaResponseDTO(response);


        }

        public async Task<CategoriaResponseDTO> ObterCategoriaPorIdAsync(int id)
        {
            var categoria = await _categoriaRepository.ObterCategoriaPorIdAsync(id);
            return MapToCategoriaResponseDTO(categoria);

        }

        public async Task<List<CategoriaResponseDTO>> ObterTodasCategoriasAsync()
        {
            var categoria = await _categoriaRepository.ObterTodasCategoriasAsync();

            return categoria.Select(MapToCategoriaResponseDTO).ToList();
        }




        private CategoriaResponseDTO MapToCategoriaResponseDTO(Categorium categoria)
        {
           if(categoria == null) {
                return null!;

            }
            return new CategoriaResponseDTO
            {
                Id = categoria.Id,
                Nome = categoria.Nome,

                IdLivros = categoria.IdLivros?.Select(l => l.Titulo).ToList()
            };


        }
    }
}
