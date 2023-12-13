using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ConsoleServer
{
    public class OrderController : ApiController
    {
        public IEnumerable<Order> GetOrders()
        {
            return Order.GetOrders();
        }

        public IEnumerable<Order> GetOrders(decimal totalPricelowerLimit)
        {
            return Order.GetOrders()
                        .Where(order => order.TotalPrice >= totalPricelowerLimit);
        }
    }
}
