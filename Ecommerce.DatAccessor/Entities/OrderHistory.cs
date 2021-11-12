using Ecommerce.DatAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Entities
{
    public class OrderHistory : BaseEntity
    {
        public Order Oder { get; set; }

        public OrderStatus OldStatus { get; set; }
        public OrderStatus NewStatus { get; set; }

        public User CreatedBy { get; set; }
        public string Note { get; set; }

    }
}
