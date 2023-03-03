using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Test
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "description");
      
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());

    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "test vendor";
      string vendorDescription = "cafe";
      Vendor newVendor = new Vendor(vendorName,vendorDescription);
      
      string result = newVendor.VendorName;
      
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "cafe";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      
      int result = newVendor.Id;
      
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string vendorName = "TestVendor";
      string vendorDescription = "cafe";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      
      string result = newVendor.VendorDescription;
      
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "SparrowCafe";
      string vendorName02 = "NewportMarket";
      string vendorDescription1 = "cafe";
      string vendorDescription2 = "market";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      
      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    {
      public void Find_ReturnsCorrectVendor_Vendor()
      {
      string vendorName01 = "SparrowCafe";
      string vendorName02 = "NewportMarket";
      string vendorDescription1 = "cafe";
      string vendorDescription2 = "market";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
      }
    }
  }
}