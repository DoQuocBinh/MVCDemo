using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToyShop.Models;

namespace MyToyShop.Controllers
{
    public class StudentCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoCreate(Student student)
        {
            if (ModelState.IsValid)
            {
                MyToyShopContext db = new MyToyShopContext();
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("List", "ProductC");
            }
            else
                return View("Index");
           
        }
    }
}
