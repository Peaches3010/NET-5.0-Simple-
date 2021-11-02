
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DatAccessor.Entities
{
   public class Product : BaseEntity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Desc { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal? Cost { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
