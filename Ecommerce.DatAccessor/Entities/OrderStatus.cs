using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Entities
{
    public enum OrderStatus
    {
        New = 1,
        
        OnHold = 10,

        Complete = 20,
        
        Shipping = 30,

        Closed = 40
    }
}
