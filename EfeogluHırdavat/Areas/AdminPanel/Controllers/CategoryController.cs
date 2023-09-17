using EfeogluHırdavat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfeogluHırdavat.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        EfeogluHırdavatDBModel db = new EfeogluHırdavatDBModel();
        // GET: AdminPanel/Category
        public ActionResult Index()
        {
            return View(db.Categories.Where(x => x.IsDeleted == false).ToList());
        }

        // GET: AdminPanel/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminPanel/Category/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Category/Create
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: AdminPanel/Category/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: AdminPanel/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: AdminPanel/Category/Delete/5
        public ActionResult Delete(int id)
        {
            Category c = db.Categories.Find(id);
            c.IsDeleted = true; 
            db.SaveChanges();
             return RedirectToAction("Index");
        }

        // POST: AdminPanel/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
