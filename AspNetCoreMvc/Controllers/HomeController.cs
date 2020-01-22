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
    }
}