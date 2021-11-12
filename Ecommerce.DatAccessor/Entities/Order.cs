using Ecommerce.DatAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Entities
{
    public class Order: BaseEntity
    {
        public Guid CustomerID { get; set; }

        [JsonIgnore]
        public User Customer { get; set; }

        public decimal SubTotal { get; set; }

        public decimal SubTotalWithDiscount { get; set; }

        public Guid ShippingAddressId { get; set;}

        public OrderAddress ShippingAddress { get; set; }

        public OrderStatus OderStatus { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

    }
}
