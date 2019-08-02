using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System;
using System.Collections.Generic;

namespace Tracker.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("title", "description", 30, "10/15/19");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnsTitle_String()
        {
            //Arrange
            string title = "Pastry order";
            string description = "15 of our best selling pastries";
            int price = 30;
            string date = "10/15/19";
            Order newOrder = new Order(title, description, price, date);

            //Act
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual(title, result);
        }
        [TestMethod]
        public void SetTitle_SetTitle_String()
        {
            //Arrange
            string title = "Pastry order";
            string description = "15 of our best selling pastries";
            int price = 30;
            string date = "10/15/19";
            Order newOrder = new Order(title, description, price, date);

            //Act
            string updatedTitle = "Best pastry order";
            newOrder.Title = updatedTitle;
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual(updatedTitle, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            // Arrange
            List<Order> newList = new List<Order> { };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            //Arrange
            string title01 = "Pastry order";
            string title02 = "Bread order";
            string description01 = "15 of our best selling pastries";
            string description02 = "5 whole wheat loaves";
            int price01 = 30;
            int price02 = 25;
            string date01 = "10/15/19";
            string date02 = "12/01/19";
            Order newOrder1 = new Order(title01, description01, price01, date01);
            Order newOrder2 = new Order(title02, description02, price02, date02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
        {
            // Arrange
            string title = "Pastry order";
            string description = "15 of our best selling pastries";
            int price = 30;
            string date = "10/15/19";
            Order newOrder = new Order(title, description, price, date);

            // Act
            int result = newOrder.Id;

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            // Arrange
            string title01 = "Pastry order";
            string title02 = "Bread order";
            string description01 = "15 of our best selling pastries";
            string description02 = "5 whole wheat loaves";
            int price01 = 30;
            int price02 = 25;
            string date01 = "10/15/19";
            string date02 = "12/01/19";
            Order newOrder1 = new Order(title01, description01, price01, date01);
            Order newOrder2 = new Order(title02, description02, price02, date02);

            // Act
            Order result = Order.Find(2);

            // Assert
            Assert.AreEqual(newOrder2, result);
        }
    }
}