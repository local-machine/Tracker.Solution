using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Victory Coffee", "Coffee shop in SoDo");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string vendorName = "Victory Coffee";
      string vendorDescription = "Coffee shop in SoDo";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string vendorName = "Victory Coffee";
      string vendorDescription = "Coffee shop in SoDo";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string vendorName01 = "Victory Coffee";
      string vendorDescription01 = "Coffee shop in SoDo";

      string vendorName02 = "Herkimer Coffee";
      string vendorDescription02 = "Coffee shop in Queen Anne";

      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newList = new List<Vendor> { newVendor01, newVendor02 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string vendorName01 = "Victory Coffee";
      string vendorDescription01 = "Coffee shop in SoDo";

      string vendorName02 = "Herkimer Coffee";
      string vendorDescription02 = "Coffee shop in Queen Anne";

      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor02, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Pastry order";
      string description = "15 of our best selling pastries";
      int price = 30;
      string date = "10/15/19";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };

      string vendorName = "Victory Coffee";
      string vendorDescription = "Coffee shop in SoDo";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
