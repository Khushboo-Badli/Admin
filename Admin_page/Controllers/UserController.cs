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
    public class UserController : Controller
    {
        private Freshers_Training2022Entities db = new Freshers_Training2022Entities();

        // GET: User
        public ActionResult Index()
        {
            return View(db.MM_User.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_User mM_User = db.MM_User.Find(id);
            if (mM_User == null)
            {
                return HttpNotFound();
            }
            return View(mM_User);
        }

        // GET: User/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserId,Name,Username,Mobile,Email,Address,PostCode,Password,ImageUrl,CreatedDate")] MM_User mM_User)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.MM_User.Add(mM_User);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(mM_User);
        //}

        //// GET: User/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MM_User mM_User = db.MM_User.Find(id);
        //    if (mM_User == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mM_User);
        //}

        //// POST: User/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "UserId,Name,Username,Mobile,Email,Address,PostCode,Password,ImageUrl,CreatedDate")] MM_User mM_User)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(mM_User).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(mM_User);
        //}

        //// GET: User/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MM_User mM_User = db.MM_User.Find(id);
        //    if (mM_User == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mM_User);
        //}

        //// POST: User/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    MM_User mM_User = db.MM_User.Find(id);
        //    db.MM_User.Remove(mM_User);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
