using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System.Collections.Generic;

namespace Tracker.Controllers
{
  public class OrdersController : Controller
  {

    // [HttpGet("/orders")]
    // public ActionResult Index()
    // {
    //   List<Order> allOrders = Order.GetAll();
    //   return View(allOrders);
    // }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
    
    // [HttpPost("/orders")]
    // public ActionResult Create(string title, string description, int price, string date)
    // {
    //   Order myOrder = new Order(title, description, price, date);
    //   return RedirectToAction("Index");
    // }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }


  }
}