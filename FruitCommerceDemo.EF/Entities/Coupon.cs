using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitCommerceDemo.EF.Entities
{
    public class Coupon : EntityBase
    {
        [Required]
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        [Column(TypeName = "decimal(6,6)")]
        public decimal DiscountPercent { get; set; }
        public string AppliesToProductIds { get; set; }
    }
}
