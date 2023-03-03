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
      Order newOrder = new Order("test", "description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";

      Order newOrder = new Order(orderTitle, orderDescription);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";
      Order newOrder = new Order(orderTitle, orderDescription);

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
      string orderDescripton1 = "birthday";
      string orderDescription2 = "wedding";
      Order newOrder1 = new Order(orderTitle01, orderDescription1);
      Order newOrder2 = new Order(orderTitle02, orderDescription1);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";
      Order newOrder = new Order(orderTitle, orderDescription);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Muffins";
      string orderTitle02 = "Scones";
      string orderDescripton1 = "birthday";
      string orderDescription2 = "wedding";
      Order newOrder1 = new Order(orderTitle01, orderDescription1);
      Order newOrder2 = new Order(orderTitle02, orderDescription2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string orderDescription = "birthday";

      Order newOrder = new Order(orderTitle, orderDescription);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }
  }
}