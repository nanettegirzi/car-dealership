using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult CreateForm()
        {
            return View ();
        }

        [HttpPost("/cars")]
        public ActionResult Create()
        {
            string newMakeModel = Request.Form["make-model"];
            int newMilage = int.Parse(Request.Form["milage"]);
            int newPrice = int.Parse(Request.Form["price"]);

            Car newCar = new Car (newMakeModel, newMilage, newPrice);
            newCar.Save();
            List<Car> allCars = Car.GetAll();
            return View("Index", allCars);
        }

        [HttpPost("/cars/delete")]
        public ActionResult DeleteAll()
        {
            Car.ClearAll();
            return View();
        }
    }
}
