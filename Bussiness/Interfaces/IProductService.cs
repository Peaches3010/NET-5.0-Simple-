
using Ecommerce.Contracts.Dtos.ProductDtos;
using Ecommerce.Contracts.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();

        Task<PageResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ProductDto> GetByIdAsync(Guid id);

        Task<IEnumerable<ProductDto>> GetProductByCategoryId(Guid id);

        Task<IEnumerable<ProductDto>> GetBestProduct();

        Task<IEnumerable<ProductDto>> GetFeaturedProduct();
        Task<ProductDto> AddAsync(ProductCreateRequest request);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ProductUpdateRequest request);
    }
}
