using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace FruitCommerceDemo.EF.Entities
{
    [Table("Product")]
    public class Product : EntityBase
    {
        public static async Task<Product> GetById(int id)
        {
            ApplicationDbContext ctx = ApplicationDbContext.GetSingleton();
            return await ctx.Products.FindAsync(id);
        }
        /*
         * KEYS
         */
        [Key]
        [Required]

        public int ProductId { get; set; }

        /*
         * BUSINESS PROPERTIES
         */
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
