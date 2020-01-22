using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Entities;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hi";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id = 1,FirstName = "Tayfun",LastName = "Karaveli", CityId = 6},
                new Employee{Id = 2,FirstName = "Tayfun2",LastName = "Karaveli2", CityId = 6},
                new Employee{Id = 3,FirstName = "Tayfun3",LastName = "Karaveli3", CityId = 34}
            };

            List<string> cities = new List<string>()
            {
                "İstanbul",
                "Ankara"
            };

            var employeeListViewModel = new EmployeeListViewModel
            {
                Employees = employees,
                Cities = cities
            };

            return View(employeeListViewModel);
        }

        public StatusCodeResult Index4()
        {
            //return StatusCode(200);
            return Ok();
        }

        public StatusCodeResult Index5()
        {
            //return StatusCode(400);
            //return BadRequest();
            return NotFound();
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/Index3");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id = 1,FirstName = "Tayfun",LastName = "Karaveli", CityId = 6},
                new Employee{Id = 2,FirstName = "Tayfun2",LastName = "Karaveli2", CityId = 6},
                new Employee{Id = 3,FirstName = "Tayfun3",LastName = "Karaveli3", CityId = 34}
            };

            return Json(employees);
        }

        
    }
}