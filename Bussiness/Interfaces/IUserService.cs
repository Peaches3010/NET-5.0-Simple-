
using System.Threading.Tasks;
using Ecommerce.Contracts.Paging;
using Ecommerce.Contracts.Dtos.UserDtos;

namespace Ecommerce.Business.Interfaces
{
    public interface IUserService
    {
        Task<PageResponseModel<UserDto>> GetAllPaging(string name, int page, int limit);
    }
}