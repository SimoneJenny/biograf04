using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class orderRepository
    {
        public Order Retrive(int OrderID)
        {
            Order Order = new Order();
            if (OrderID == 10)
            {
                Order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return Order;
        }
        public bool Save(Order order)
        {
            return true;
        }


	}

    
}
