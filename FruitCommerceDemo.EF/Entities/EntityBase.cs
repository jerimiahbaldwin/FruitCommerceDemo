using System;
using System.ComponentModel.DataAnnotations;

namespace FruitCommerceDemo.EF.Entities
{
    public abstract class EntityBase
    {
        /*
         * METADATA FIELDS
         */
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
        [Required]
        public string Source { get; set; } = "WebApp";
        [Required]
        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
