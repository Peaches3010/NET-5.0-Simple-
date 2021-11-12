using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Business.Interfaces;
using Ecommerce.Contracts.Dtos.UserDtos;
using Ecommerce.Contracts.Paging;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<PageResponseModel<UserDto>> GetUserPaging(string name, int page = 1, int limit = 10)
        {
            return await _userService.GetAllPaging(name, page,limit);
        }
    }
}