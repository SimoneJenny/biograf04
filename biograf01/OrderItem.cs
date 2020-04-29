using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace biograf01
{
    public class OrderItem
    {
        public OrderItem()
        { }

        public OrderItem(int OrderItemId)
        { OrderItemId = OrderItemId; }

        public int orderItemId { get; private set; }
        public int productId { get; set; }
        public decimal? purchaePrice { get; set; }
        public int quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }

        public bool validate()
        {
            var isvalid = true;
            if (quantity <= 0) isvalid = false;
            if (productId <= 0) isvalid = false;
            if (purchaePrice <= 0) isvalid = false;
            return isvalid;
        }
    }
}
