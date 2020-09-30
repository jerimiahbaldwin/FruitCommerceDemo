using System.ComponentModel.DataAnnotations;

namespace FruitCommerceDemo.EF.Entities
{
    public class ShoppingCartCoupon : EntityBase
    {
        [Required]
        [Key]
        public int ShoppingCartCouponId { get; set; }
        [Required]
        public ShoppingCart ShoppingCart { get; set; }
        [Required]
        public Coupon Coupon { get; set; }
    }
}
