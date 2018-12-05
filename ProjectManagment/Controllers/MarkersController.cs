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
    public class MarkersController : Controller
    {
        private Model1 db = new Model1();

        // GET: Markers
        public ActionResult Index()
        {
            List<Marker> markerList = db.Marker.ToList();
            foreach(Marker merker in markerList)
            {
                merker.accountantName = db.Accountant.Find(merker.id_accountant).name;
            }
            return View(markerList);
        }

        // GET: Markers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marker marker = db.Marker.Find(id);
            if (marker == null)
            {
                return HttpNotFound();
            }
            marker.accountantName = db.Accountant.Find(marker.id_accountant).name;
            return View(marker);
        }

        // GET: Markers/Create
        public ActionResult Create()
        {
            ViewBag.test = db.Accountant.ToList<Accountant>();
            
            return View();
        }

        // POST: Markers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,label,best_end_date,id_accountant,real_end_date")] Marker marker)
        {                   
            if (ModelState.IsValid)
            {
                db.Marker.Add(marker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marker);
        }

        // GET: Markers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marker marker = db.Marker.Find(id);
            if (marker == null)
            {
                return HttpNotFound();
            }
            ViewBag.test = db.Accountant.ToList<Accountant>();
            return View(marker);
        }

        // POST: Markers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,label,best_end_date,id_accountant,real_end_date")] Marker marker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marker);
        }

        // GET: Markers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marker marker = db.Marker.Find(id);
            if (marker == null)
            {
                return HttpNotFound();
            }
            return View(marker);
        }

        // POST: Markers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marker marker = db.Marker.Find(id);
            db.Marker.Remove(marker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public ActionResult ListAccountants()
        //{
        //    var accountants = db.Accountant.ToList();

        //    var viewModel = new ViewModelMarker { Accountants = accountants };

        //    return View(viewModel);
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
