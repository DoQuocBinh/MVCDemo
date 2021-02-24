using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToyShop.Models;

namespace MyToyShop.Controllers
{
    public class ProductCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            MyToyShopContext db = new MyToyShopContext();
            return View(db.MyToys.ToList());

        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult DoCreate(MyToy toy)
        {
            if (ModelState.IsValid)
            {
                MyToyShopContext db = new MyToyShopContext();
                db.MyToys.Add(toy);
                db.SaveChanges();
                //redirect user to view all Products
                return RedirectToAction("List");
            }
            else
                return View("Create");
           
        }
    }
}
