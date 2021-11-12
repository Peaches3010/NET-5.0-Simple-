using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Contracts.Dtos.UserDtos
{
    public class UserDto
    {
        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        //public IList<string> Roles { get; set; }
    }
}