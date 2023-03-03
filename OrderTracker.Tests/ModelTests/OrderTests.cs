using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string orderTitle = "Muffins";

      Order newOrder = new Order(orderTitle);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string orderTitle = "Muffins";
      Order newOrder = new Order(orderTitle);

      string updatedOrderTitle = "Scones";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;

      Assert.AreEqual(updatedOrderTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderTitle01 = "Muffins";
      string orderTitle02 = "Scones";
      Order newOrder1 = new Order(orderTitle01);
      Order newOrder2 = new Order(orderTitle02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderTitle = "Muffins";
      Order newOrder = new Order(orderTitle);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
  }
}