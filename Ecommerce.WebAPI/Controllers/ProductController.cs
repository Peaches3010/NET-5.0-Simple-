using Ecommerce.Business.Interfaces;
using Ecommerce.Contracts.Dtos.ProductDtos;
using Ecommerce.Contracts.Paging;
using Ecommerce.WebAPI.StorageService;
using EnsureThat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IStorageService _storageService;

        public ProductController(IProductService productService, IStorageService storageService)
        {
            _productService = productService;
            _storageService = storageService;
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> AddProductAsync([FromForm]ProductCreateRequest request)
        {
            var product = await _productService.AddAsync(request); 

            if( request.ImageUrl != null)
            {
                product.ImageUrl = await SaveFile(request.ImageUrl);
            }
            return product;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _productService.GetAllAsync();
            return products;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProductAsync(Guid id,[FromForm]ProductUpdateRequest request)
        {

            var productDb = await _productService.GetByIdAsync(id);
            if(productDb == null)
            {
                return NotFound();
            }

            productDb.Name = request.Name;
            productDb.Price = request.Price;
            productDb.IsFeatured = request.IsFeatured;
            productDb.Desc = request.Desc;
            productDb.Cost = request.Cost;
            productDb.CategoryId = request.CategoryId;

            // update Image
            if(request.ImageUrl != null)
            {
                productDb.ImageUrl = await SaveFile(request.ImageUrl);
            }    
          
            await _productService.UpdateAsync(request);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductAsync([FromRoute] Guid id) 
        {
            var productDto = await _productService.GetByIdAsync(id);
            Ensure.Any.IsNotNull(productDto, nameof(productDto));
            await _productService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> GetProductByIdAsync([FromRoute] Guid id)
         => await _productService.GetByIdAsync(id);

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
