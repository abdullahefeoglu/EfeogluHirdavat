using EfeogluHırdavat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfeogluHırdavat.Areas.AdminPanel.Controllers
{
    public class SubCategoryController : Controller
    {
        EfeogluHırdavatDBModel db = new EfeogluHırdavatDBModel();
        // GET: AdminPanel/SubCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminPanel/SubCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminPanel/SubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/SubCategory/Create
        [HttpPost]
        public ActionResult Create(SubCategory model)
        {
            if (ModelState.IsValid)
            {
                db.SubCategories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: AdminPanel/SubCategory/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            SubCategory subcategory = db.SubCategories.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // POST: AdminPanel/SubCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(SubCategory model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: AdminPanel/SubCategory/Delete/5
        public ActionResult Delete(int id)
        {
            SubCategory sc = db.SubCategories.Find(id);
            sc.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: AdminPanel/SubCategory/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            return View();
        }
    }
}
