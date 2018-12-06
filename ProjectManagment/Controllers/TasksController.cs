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
    public class TasksController : Controller
    {
        private Model1 db = new Model1();

        // GET: Tasks
        public ActionResult Index()
        {
            List<Task> taskList = db.Task.ToList();
            foreach(Task tesk in taskList)
            {
                tesk.accountantName = db.Accountant.Find(tesk.id_accountant).name;
            }
            return View(taskList);
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Task.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            task.accountantName = db.Accountant.Find(task.id_accountant).name;
            return View(task);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            ViewBag.test = db.Accountant.ToList<Accountant>();

            List<Task> taskList = db.Task.ToList<Task>();
            List<string> taskIDSList = new List<string>();
            foreach(Task tesk in taskList)
            {
                taskIDSList.Add(tesk.taskId);
            }
            return View();
        }

        // POST: Tasks/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,taskId,id_accountant,scheduled_start_date,work_load,required_taskID,status,real_start_date")] Task task)
        {
            if (ModelState.IsValid)
            {
                db.Task.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Task.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            ViewBag.test = db.Accountant.ToList<Accountant>();
            return View(task);
        }

        // POST: Tasks/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,taskId,id_accountant,scheduled_start_date,work_load,required_taskID,status,real_start_date")] Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Task task = db.Task.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            task.accountantName = db.Accountant.Find(task.id_accountant).name;
            return View(task);
        }

        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task task = db.Task.Find(id);
            db.Task.Remove(task);
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
