using MovieStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.App.Services
{
    public class EmployeeService
    {
        public List<Employee> Employees { get; set; }

        public EmployeeService()
        {
            Employees = new List<Employee>() { 
                new Employee("Kristijan", "Jankuloski", 25, "kiko", "password", 120),
            };
        }
    }
}
