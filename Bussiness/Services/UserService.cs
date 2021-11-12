using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.Business.Extensions;
using Ecommerce.Business.Interfaces;
using Ecommerce.Business.Repositories;
using Ecommerce.Contracts.Dtos.UserDtos;
using Ecommerce.Contracts.Paging;
using Ecommerce.DataAccessor.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<PageResponseModel<UserDto>> GetAllPaging(string name, int page, int limit)
        {
            var query = _repository.Entites;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.UserName.Contains(name))
                         .OrderBy(x => x.UserName);

            var users = await query.AsNoTracking()
                                    .PaginateAsync(page, limit);

            return new PageResponseModel<UserDto>
            {
                CurrentPage = users.CurrentPage,
                TotalItems = users.TotalItems,
                TotalPages = users.TotalPages,
                Items = _mapper.Map<IEnumerable<UserDto>>(users.Items)
            };
        }
    }
}