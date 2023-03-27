using MovieStore.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Models
{
    public class Employee : User
    {
        private double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public Employee(){}
        public Employee(string firstName, string lastName, int age, string username, string password, int hoursPerMonth): base(firstName, lastName, age, username, password, UserRoles.Employee)
        {
            HoursPerMonth = hoursPerMonth;
            SetBonus();
            SetSalary();
        }
        public void SetBonus()
        {
            Bonus = HoursPerMonth >= 160 ? 0.3 : 0;
        }

        public void SetSalary()
        {
            Salary = HoursPerMonth * (Bonus + 1);
        }
    }
}
