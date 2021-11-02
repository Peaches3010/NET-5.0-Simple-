using Ecommerce.Contracts.Dtos;
using Ecommerce.Contracts.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Interfaces
{
    public interface ICategoryService
    {

        Task<IEnumerable<CategoryDto>> GetAllAsync();

        Task<PageResponseModel<CategoryDto>> PagedQueryAsync(string name, int page, int limit);

        Task<CategoryDto> GetByIdAsync(Guid id);

        Task<CategoryDto> AddAsync(CategoryDto categoryDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(CategoryDto categoryDto);
    }
}
