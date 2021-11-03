
using Ecommerce.Business.Interfaces;
using Ecommerce.Contracts.Constants;
using Ecommerce.Contracts.Dtos;
using Ecommerce.Contracts.Paging;
using EnsureThat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace Ecommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize(LocalApi.PolicyName)]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
       
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            return await _categoryService.GetAllAsync();
        }

        [HttpGet("find")]
        public async Task<PageResponseModel<CategoryDto>>
            FindAsync(string name, int page = 1, int limit = 10)
            => await _categoryService.PagedQueryAsync(name, page, limit);

        [HttpPost]
        [Authorize("ADMIN_ROLE_POLICY")]
        public async Task<ActionResult<CategoryDto>> CreateAsync([FromBody]CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            var asset = await _categoryService.AddAsync(categoryDto);
            return Created(EndPoint.Category,asset);
        }

        [HttpGet("{id}")]
        public async Task<CategoryDto> GetCategoryByIdAsync([FromRoute] Guid id)
         => await _categoryService.GetByIdAsync(id);

        [HttpPut]
        [Authorize("ADMIN_ROLE_POLICY")]
        public async Task<IActionResult> UpdateAsync([FromBody]CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            Ensure.Any.IsNotNull(categoryDto.Id, nameof(categoryDto.Id));
            await _categoryService.UpdateAsync(categoryDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize("ADMIN_ROLE_POLICY")]
        public async Task<ActionResult> DeleteAssetAsync([FromRoute] Guid id)
        {
            var categoryDto = await _categoryService.GetByIdAsync(id);
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}
