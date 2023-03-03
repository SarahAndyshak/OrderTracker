using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }
  }
}