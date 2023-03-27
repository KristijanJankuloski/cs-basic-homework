using MovieStore.App.Services;
using MovieStore.Models.Enums;
using MovieStore.Models.Models;

MovieService movieService = new MovieService();
EmployeeService employeeService = new EmployeeService();
MemberService memberService = new MemberService();

memberService.Members.Add(new Member(2, "John", "Doe", 23, "jd", "jd", Subscriptions.Monthly));