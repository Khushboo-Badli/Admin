using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Admin_page.Models;

namespace Admin_page.Controllers
{
    public class CategoriesController : Controller
    {
        private Freshers_Training2022Entities db = new Freshers_Training2022Entities();

        // GET: Categories
        public ActionResult Index()
        {
            return View(db.MM_Categories.ToList());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Categories mM_Categories = db.MM_Categories.Find(id);
            if (mM_Categories == null)
            {
                return HttpNotFound();
            }
            return View(mM_Categories);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryId,Name,ImageUrl,IsActive,CreatedDate")] MM_Categories mM_Categories)
        {
            if (ModelState.IsValid)
            {
                db.MM_Categories.Add(mM_Categories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mM_Categories);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Categories mM_Categories = db.MM_Categories.Find(id);
            if (mM_Categories == null)
            {
                return HttpNotFound();
            }
            return View(mM_Categories);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryId,Name,ImageUrl,IsActive,CreatedDate")] MM_Categories mM_Categories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mM_Categories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mM_Categories);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Categories mM_Categories = db.MM_Categories.Find(id);
            if (mM_Categories == null)
            {
                return HttpNotFound();
            }
            return View(mM_Categories);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MM_Categories mM_Categories = db.MM_Categories.Find(id);
            db.MM_Categories.Remove(mM_Categories);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
