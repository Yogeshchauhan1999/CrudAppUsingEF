using Microsoft.AspNetCore.Mvc;
using TestApplication.ApplicationDB;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DbConnection context;

        public EmployeeController(DbConnection context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var result = context.EmployeeDatas.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeData model)
        {
            if (ModelState.IsValid)
            {
                var emp = new EmployeeData()
                {
                    
                    Name = model.Name,
                    Gender = model.Gender,
                    EmailID = model.EmailID,
                    Dptname = model.Dptname,
                    Salary = model.Salary

                };

               
                context.EmployeeDatas.Add(emp);
                context.SaveChanges();
                return RedirectToAction("Index");
                
                
            }

            else
            {
                TempData["error message"]= "Empty Data can't be submit";
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
            var record=context.EmployeeDatas.SingleOrDefault(emp => emp.Id == id);
            context.EmployeeDatas.Remove(record);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = context.EmployeeDatas.SingleOrDefault(emp => emp.Id == id);
            var result = new EmployeeData
            {
                Name = record.Name,
                Gender = record.Gender,
                EmailID = record.EmailID,
                Dptname = record.Dptname,
                Salary = record.Salary

            };
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeData model)
        {
            var emp = new EmployeeData()
            {
                Id = model.Id,
               Name= model.Name,
               Gender = model.Gender,
               EmailID = model.EmailID,
               Dptname = model.Dptname,
               Salary = model.Salary
            };

            context.EmployeeDatas.Update(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
