using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitCommerceDemo.EF.Entities
{
    public class ShoppingCartItem : EntityBase
    {
        [Required]
        [Key]
        public int ShoppingCartItemId { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        public int Quantity { get; set; }
        [Required]
        public ShoppingCart ShoppingCart { get; set; }
        [Required]
        public Product Product { get; set; }
    }
}
