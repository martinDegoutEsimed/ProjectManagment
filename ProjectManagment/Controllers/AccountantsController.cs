using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectManagment.Models;

namespace ProjectManagment.Controllers
{
    public class AccountantsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Accountants
        public ActionResult Index()
        {
            return View(db.Accountant.ToList());
        }

        // GET: Accountants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accountant accountant = db.Accountant.Find(id);
            if (accountant == null)
            {
                return HttpNotFound();
            }
            return View(accountant);
        }

        // GET: Accountants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accountants/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name")] Accountant accountant)
        {
            if (ModelState.IsValid)
            {
                db.Accountant.Add(accountant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accountant);
        }

        // GET: Accountants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accountant accountant = db.Accountant.Find(id);
            if (accountant == null)
            {
                return HttpNotFound();
            }
            return View(accountant);
        }

        // POST: Accountants/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name")] Accountant accountant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accountant);
        }

        // GET: Accountants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accountant accountant = db.Accountant.Find(id);
            if (accountant == null)
            {
                return HttpNotFound();
            }
            return View(accountant);
        }

        // POST: Accountants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accountant accountant = db.Accountant.Find(id);
            db.Accountant.Remove(accountant);
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
