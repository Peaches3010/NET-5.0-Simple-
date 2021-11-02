using AutoMapper;
using Ecommerce.Business.Extensions;
using Ecommerce.Business.Interfaces;
using Ecommerce.Business.Repositories;
using Ecommerce.Contracts.Constants;
using Ecommerce.Contracts.Dtos.ProductDtos;
using Ecommerce.Contracts.Paging;
using Ecommerce.DatAccessor.Entities;
using EnsureThat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProductDto> AddAsync(ProductCreateRequest request)
        {
            Ensure.Any.IsNotNull(request, nameof(request));

            var product = _mapper.Map<Product>(request);
            var item = await _repository.AddAsync(product);
            return _mapper.Map<ProductDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
             await _repository.DeleteAsync(id);
        }
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var product = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(product);
        }

        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var product = await _repository.GetByIdAsync(id);

            if(product == null)
            {
                throw new Exception(ErrorTypes.Common.NotFound);
            }

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<PageResponseModel<ProductDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _repository.Entites;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name))
                        .OrderBy(x => x.Name);

            var products = await query.AsNoTracking()
                                    .PaginateAsync(page, limit);

            return new PageResponseModel<ProductDto>
            {
                CurrentPage = products.CurrentPage,
                TotalItems = products.TotalItems,
                TotalPages = products.TotalPages,
                Items = _mapper.Map<IEnumerable<ProductDto>>(products.Items)
            };
        }

        public async Task UpdateAsync(ProductUpdateRequest request)
        {
                var product = _mapper.Map<Product>(request);
                await _repository.UpdateAsync(product);
        }
    }
}
