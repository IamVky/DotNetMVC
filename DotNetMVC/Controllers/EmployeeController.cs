using DotNetMVC.Models;
using System.Web.Mvc;
using DotNetMVC.DAL;

namespace DotNetMVC.Controllers {
    public class EmployeeController : Controller {
        // GET: Employee
        public ActionResult Index(int id) {
            Employee employee = new Employee();
            EmployeeDL employeeDL = new EmployeeDL();
            employee = employeeDL.GetEmployee(id);
            return View(employee);
        }

        // GET: Employee by ID
        public ActionResult Details(int? id) {

            return View();
        }
    }
}