using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesBotelho.Models
{
  [Table("Categories")]
  public class Category
  {
    [Key]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Informe o nome da categoria")]
    [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Descrição")]
    [Required(ErrorMessage = "Informe a descrição da categoria")]
    [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
    public string Description { get; set; }

    public List<Snack> Snacks { get; set; }
  }
}
