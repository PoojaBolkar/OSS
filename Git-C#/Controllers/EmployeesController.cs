using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HRWebApplication.Models;
namespace HRWebApplication.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> list = HRManager.getData();
            return View(list);
        }
        public ActionResult Create()
        {
            List<Employee> list = HRManager.getData();
            return View(list);
        }
    }
}