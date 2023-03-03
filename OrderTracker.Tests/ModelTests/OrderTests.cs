using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder);
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string orderTitle = "Muffins";

      Order newOrder = new Order(orderTitle);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }
  }
}