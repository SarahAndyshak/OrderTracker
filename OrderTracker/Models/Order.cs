using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDetails { get; set; }
    public Order(string orderDetails)
    {
      OrderDetails = orderDetails;
    }
  }
}