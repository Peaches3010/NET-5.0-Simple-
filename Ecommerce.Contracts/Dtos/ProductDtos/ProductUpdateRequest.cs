using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Contracts.Dtos.ProductDtos
{
    public class ProductUpdateRequest
    {
        public string Name { get; set; }

        public string Desc { get; set; }

        public IFormFile ImageUrl { get; set; }

        public decimal Price { get; set; }

        public decimal? Cost { get; set; }

        public bool IsFeatured { get; set; }

        public Guid? CategoryId { get; set; }
    }
}
