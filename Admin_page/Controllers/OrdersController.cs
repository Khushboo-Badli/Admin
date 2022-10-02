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
    public class OrdersController : Controller
    {
        private Freshers_Training2022Entities db = new Freshers_Training2022Entities();

        // GET: Orders
        public ActionResult Index()
        {
            return View(db.MM_Orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Orders mM_Orders = db.MM_Orders.Find(id);
            if (mM_Orders == null)
            {
                return HttpNotFound();
            }
            return View(mM_Orders);
        }

        // GET: Orders/Create
        /*
        public ActionResult Create()
        {
            return View();
        }
        */
        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*
        public ActionResult Create([Bind(Include = "OrderDetailsid,OrderNo,ProductId,Quantity,UserId,Status,PaymentId,OrderDate")] MM_Orders mM_Orders)
        {
            if (ModelState.IsValid)
            {
                db.MM_Orders.Add(mM_Orders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mM_Orders);
        }
        */

        // GET: Orders/Edit/5
        /*
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Orders mM_Orders = db.MM_Orders.Find(id);
            if (mM_Orders == null)
            {
                return HttpNotFound();
            }
            return View(mM_Orders);
        }
        
        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderDetailsid,OrderNo,ProductId,Quantity,UserId,Status,PaymentId,OrderDate")] MM_Orders mM_Orders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mM_Orders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mM_Orders);
        }
        */

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Orders mM_Orders = db.MM_Orders.Find(id);
            if (mM_Orders == null)
            {
                return HttpNotFound();
            }
            return View(mM_Orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MM_Orders mM_Orders = db.MM_Orders.Find(id);
            db.MM_Orders.Remove(mM_Orders);
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
