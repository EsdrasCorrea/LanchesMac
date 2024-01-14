using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = ("O tamanho máximo é de {1} caracteres"))]
        public string CategoriaName { get; set; }

        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição")]
        [StringLength(200, ErrorMessage = ("O tamanho máximo é de {1} caracteres"))]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
