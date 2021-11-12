using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Entities
{
    public class OrderAddress
    {
        [StringLength(450)]
        public string ContactName { get; set; }

        [StringLength(450)]
        public string Phone { get; set; }

        [StringLength(450)]
        public string AddressLine{ get; set; }

      
        [StringLength(450)]
        public string City { get; set; }

    }
}
