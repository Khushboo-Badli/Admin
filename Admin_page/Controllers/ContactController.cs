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
    public class ContactController : Controller
    {
        private Freshers_Training2022Entities db = new Freshers_Training2022Entities();

        // GET: Contact
        public ActionResult Index()
        {
            return View(db.MM_Contact.ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Contact mM_Contact = db.MM_Contact.Find(id);
            if (mM_Contact == null)
            {
                return HttpNotFound();
            }
            return View(mM_Contact);
        }

        // GET: Contact/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ContactId,Name,Email,Subject,Message,CreatedDate")] MM_Contact mM_Contact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.MM_Contact.Add(mM_Contact);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(mM_Contact);
        //}

        // GET: Contact/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MM_Contact mM_Contact = db.MM_Contact.Find(id);
        //    if (mM_Contact == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mM_Contact);
        //}

        // POST: Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ContactId,Name,Email,Subject,Message,CreatedDate")] MM_Contact mM_Contact)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(mM_Contact).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(mM_Contact);
        //}

        // GET: Contact/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MM_Contact mM_Contact = db.MM_Contact.Find(id);
        //    if (mM_Contact == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(mM_Contact);
        //}

        // POST: Contact/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    MM_Contact mM_Contact = db.MM_Contact.Find(id);
        //    db.MM_Contact.Remove(mM_Contact);
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
