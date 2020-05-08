using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }


        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }


        public bool Validate()
        {
            return OrderDate != null;
        }

    }
}
