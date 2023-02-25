using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        HRDatabaseContext dbContext = new HRDatabaseContext();
        public IActionResult Index()
        {
            List<Employee> employees = (from employee in dbContext.Employees
                                        join department in dbContext.Departments on employee.EmployeeID equals department.DepartmentId
                                        select new Employee
                                        {
                                            EmployeeID = employee.EmployeeID,
                                            EmployeeNumber = employee.EmployeeNumber,
                                            EmployeeName = employee.EmployeeName,
                                            DOB = employee.DOB,
                                            HirindDate = employee.HirindDate,
                                            GrossSalary = employee.GrossSalary,
                                            NetSalary = employee.NetSalary,
                                            DepartmentId = employee.DepartmentId,
                                            DepartmentName = department.DepartmentName
                                        }).ToList();
            return View(employees);
        }
        public IActionResult Create()
        {
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                dbContext.Employees.Add(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = this.dbContext.Departments.ToList();
            return View();
        }
    }
}
