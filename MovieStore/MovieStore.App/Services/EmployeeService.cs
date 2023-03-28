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
        public Dictionary<string,Employee> Employees { get; set; }

        public EmployeeService()
        {
            Employees = new Dictionary<string, Employee>
            {
                { "kiko", new Employee("Kristijan", "Jankuloski", 25, "kiko", "password", 120) }
            };
        }

        public void Add(Employee employee)
        {
            Employees.Add(employee.UserName, employee);
        }
        public Employee LogIn(string username, string password)
        {
            if(!Employees.ContainsKey(username))
            {
                throw new Exception("Username or password is incorrect.");
            }
            if (!Employees[username].ChechPassword(password))
            {
                throw new Exception("Username or password is incorrect.");
            }
            return Employees[username];
        }
    }
}
