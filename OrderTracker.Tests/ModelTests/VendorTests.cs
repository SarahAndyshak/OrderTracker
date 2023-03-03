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
  }
  
}