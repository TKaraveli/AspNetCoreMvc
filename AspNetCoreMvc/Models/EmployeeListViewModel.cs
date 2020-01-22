using System.Collections.Generic;
using AspNetCoreMvc.Entities;

namespace AspNetCoreMvc.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}