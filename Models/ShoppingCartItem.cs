using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesBotelho.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Snack Snack { get; set; }
        public int Amount { get; set; }

        [StringLength(200)]
        public string ShoppingCartId { get; set; }
    }
}
