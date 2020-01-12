using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyWeb.Web.Areas.Administrator.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        [Area("Administrator")]
        public ActionResult Index()
        {
            Models.CategoryViewModel model = new Models.CategoryViewModel();
            List<Models.CategoryViewModel> list = new List<Models.CategoryViewModel>();
            list.Add(new Models.CategoryViewModel { CategoryId = 1, CategoryName = "C1" });
            list.Add(new Models.CategoryViewModel { CategoryId = 2, CategoryName = "C2" });
            list.Add(new Models.CategoryViewModel { CategoryId = 3, CategoryName = "C3" });
            list.Add(new Models.CategoryViewModel { CategoryId = 4, CategoryName = "C4" });
            list.Add(new Models.CategoryViewModel { CategoryId = 5, CategoryName = "C5" });
            list.Add(new Models.CategoryViewModel { CategoryId = 6, CategoryName = "C6" });
            list.Add(new Models.CategoryViewModel { CategoryId = 7, CategoryName = "C7" });
            return View(list);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}