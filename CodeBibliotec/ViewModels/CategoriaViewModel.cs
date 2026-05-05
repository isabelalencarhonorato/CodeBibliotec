using System.ComponentModel.DataAnnotations;

namespace CodeBibliotec.ViewModels
{
    public class CategoriaViewModel
    {
        [Required (ErrorMessage = "O campo Nome da categoria é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome não pode ter mais de 50 caracteres.")]

        public string Nome { get; set; }
    }
}
