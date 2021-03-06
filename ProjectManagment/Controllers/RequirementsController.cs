﻿using System;
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
    public class RequirementsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Requirements
        public ActionResult Index()
        {
            List<Requirement> reqList = db.Requirement.ToList();
            foreach (Requirement req in reqList)
            {
                req.projectName = db.Project.Find(req.id_project).name;
                req.taskIdentifier = db.Task.Find(req.task_ID).taskId;
            }
            return View(reqList);
        }

        // GET: Requirements/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requirement requirement = db.Requirement.Find(id);
            if (requirement == null)
            {
                return HttpNotFound();
            }
            requirement.projectName = db.Project.Find(requirement.id_project).name;
            requirement.taskIdentifier = db.Task.Find(requirement.task_ID).taskId;
            return View(requirement);
        }

        // GET: Requirements/Create
        public ActionResult Create()
        {
            ViewBag.test = db.Project.ToList<Project>();
            ViewBag.teest = db.Task.ToList<Task>();
            return View();
        }

        // POST: Requirements/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,reqId,detail,type,id_project,task_ID")] Requirement requirement)
        {
            if (ModelState.IsValid)
            {
                db.Requirement.Add(requirement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requirement);
        }

        // GET: Requirements/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requirement requirement = db.Requirement.Find(id);
            if (requirement == null)
            {
                return HttpNotFound();
            }
            ViewBag.test = db.Project.ToList<Project>();
            ViewBag.teest = db.Task.ToList<Task>();
            return View(requirement);
        }

        // POST: Requirements/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,reqId,detail,type,id_project,task_ID")] Requirement requirement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requirement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requirement);
        }

        // GET: Requirements/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Requirement requirement = db.Requirement.Find(id);
            if (requirement == null)
            {
                return HttpNotFound();
            }
            requirement.projectName = db.Project.Find(requirement.id_project).name;
            requirement.taskIdentifier = db.Task.Find(requirement.task_ID).taskId;
            return View(requirement);
        }

        // POST: Requirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Requirement requirement = db.Requirement.Find(id);
            db.Requirement.Remove(requirement);
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
