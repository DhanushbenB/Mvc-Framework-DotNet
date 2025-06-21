using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using emp_details.Models;
using emp_details.Context;

namespace emp_details.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly EmployeeDBcontext _employeeDBcontext;
        public EmployeeController(EmployeeDBcontext employeeDBcontext)
        {
            _employeeDBcontext= employeeDBcontext;
        }


        // GET: EmployeeController
        public ActionResult Index()
        {

            IEnumerable<Employee>obj = _employeeDBcontext.Employees;
            return View(obj);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {

            var empDB = _employeeDBcontext.Employees.Find(id);
            if (id == null || id == 0)
            {
                return NotFound();
            }
            return View(empDB);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeDBcontext.Employees.Add(employee);
                _employeeDBcontext.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully";
                return RedirectToAction("Index");

            }
            return View(employee);
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var empDB=_employeeDBcontext.Employees.Find(id);
            if (empDB == null)
            {
                return NotFound();
            }
            return View(empDB);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeDBcontext.Employees.Update(employee);
                _employeeDBcontext.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully";
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var emp = _employeeDBcontext.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            _employeeDBcontext.Employees.Remove(emp);
            _employeeDBcontext.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully";
            return RedirectToAction("Index");
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
