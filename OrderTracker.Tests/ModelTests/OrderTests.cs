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
      Order newOrder = new Order("test", "description", 5, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsTitle_String()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";
      int orderPrice = 5; 
      string orderDate = "March 3";

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";
      int orderPrice = 5;
      string orderDate = "March 3";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

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
      string orderDescription01 = "Birthday";
      string orderDescription02 = "Wedding";
      int orderPrice01 = 5;
      int orderPrice02 = 6;
      string orderDate01 = "March 3";
      string orderDate02 = "May 5";
      Order newOrder1 = new Order(orderTitle01, orderDescription01, orderPrice01, orderDate01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02, orderPrice02, orderDate02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderTitle = "Muffins";
      string orderDescription = "birthday";
      int orderPrice = 5;
      string orderDate = "March 3";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle01 = "Muffins";
      string orderTitle02 = "Scones";
      string orderDescripton01 = "birthday";
      string orderDescription02 = "wedding";
      int orderPrice01 = 5;
      int orderPrice02 = 6;
      string orderDate01 = "March 3";
      string orderDate02 = "May 5";

      Order newOrder1 = new Order(orderTitle01, orderDescripton01, orderPrice01, orderDate01);
      Order newOrder2 = new Order(orderTitle02, orderDescription02, orderPrice02, orderDate02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string orderTitle = "SparrowCafe";
      string orderDescription = "birthday";
      int orderPrice = 5;
      string orderDate = "March 3";

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsPrice_Int()
    {
      string orderTitle = "SparrowCafe";
      string orderDescription = "birthday";
      int orderPrice = 5;
      string orderDate = "March 3";

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      int result = newOrder.OrderPrice;

      Assert.AreEqual(orderPrice, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsDate_String()
    {
      string orderTitle = "SparrowCafe";
      string orderDescription = "birthday";
      int orderPrice = 5;
      string orderDate = "March 3";

      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderDate;

      Assert.AreEqual(orderDate, result);
      }
  }
}