using AutoMapper;
using Ecommerce.Business.Interfaces;
using Ecommerce.Business.Repositories;
using Ecommerce.Contracts.Dtos;
using Ecommerce.Contracts.Paging;
using Ecommerce.DatAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EnsureThat;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Business.Extensions;

namespace Ecommerce.Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category>_repository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            Ensure.Any.IsNotNull(categoryDto, nameof(categoryDto));

            var category = _mapper.Map<Category>(categoryDto);

            var item = await _repository.AddAsync(category);

            return _mapper.Map<CategoryDto>(item);

        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categoryList = await _repository.GetAllAsync();

            return  _mapper.Map<IEnumerable<CategoryDto>>(categoryList);
        }

        public async Task<CategoryDto> GetByIdAsync(Guid id)
        {
            var category = await _repository.GetByIdAsync(id);

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<PageResponseModel<CategoryDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _repository.Entites;

            query = query.Where(x => string.IsNullOrEmpty(name)|| x.Name.Contains(name))
                         .OrderBy(x =>x.Name);

            var categories = await query.AsNoTracking()
                                    .PaginateAsync(page, limit);

            return new PageResponseModel<CategoryDto>
            {
                CurrentPage = categories.CurrentPage,
                TotalItems = categories.TotalItems,
                TotalPages = categories.TotalPages,
                Items = _mapper.Map<IEnumerable<CategoryDto>>(categories.Items)
            };
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            await _repository.UpdateAsync(category);
        }
    }
}
