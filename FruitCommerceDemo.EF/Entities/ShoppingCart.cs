using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FruitCommerceDemo.EF.Entities
{
    public class ShoppingCart : EntityBase
    {
        [Key]
        [Required]
        public int ShoppingCartId { get; set; }
        [Required]
        public string SessionId { get; set; }
        public ICollection<ShoppingCartItem> Items { get; set; }
        public ICollection<ShoppingCartCoupon> Coupons { get; set; }
    }
}
