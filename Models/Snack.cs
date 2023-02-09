using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesBotelho.Models
{
    [Table("Snacks")]
    public class Snack
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Lanche")]
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Name { get; set; }

        [Display(Name = "Descrição do Lanche")]
        [Required(ErrorMessage = "A descrição do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescriptionShort { get; set; }

        [Display(Name = "Descrição detalhada do Lanche")]
        [Required(ErrorMessage = "O descrição detalhada do lanche deve ser informada")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DescriptionLong { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsFavorite { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
