using Ecommerce.DatAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Entities
{
    public class OrderItem : BaseEntity
    {
        public Order Oder { get; set; }

        public Guid ProductID { get; set; }

        public decimal ProductPrice { get; set; }

        public int Quantity { get; set; }

        public decimal DiscountAmount { get; set; }
    }
}
