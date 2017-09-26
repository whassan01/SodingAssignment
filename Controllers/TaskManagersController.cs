using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SodingAssignment.Models;

namespace SodingAssignment.Controllers
{
    public class TaskManagersController : Controller
    {
        private TaskManagerContext db = new TaskManagerContext();

        // GET: TaskManagers
        public ActionResult Index()
        {
            return View(db.TaskManagers.ToList());
        }

        // GET: TaskManagers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskManager taskManager = db.TaskManagers.Find(id);
            if (taskManager == null)
            {
                return HttpNotFound();
            }
            return View(taskManager);
        }

        // GET: TaskManagers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskManagers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskManagerID,Name,Description,CreatedDate,UpdatedDate")] TaskManager taskManager)
        {
            if (ModelState.IsValid)
            {
                taskManager.CreatedDate = DateTime.Now; // added by Waqar Hassan on 20170926, "to set value of property"
                db.TaskManagers.Add(taskManager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskManager);
        }

        // GET: TaskManagers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskManager taskManager = db.TaskManagers.Find(id);
            if (taskManager == null)
            {
                return HttpNotFound();
            }
            return View(taskManager);
        }

        // POST: TaskManagers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskManagerID,Name,Description,CreatedDate,UpdatedDate")] TaskManager taskManager)
        {
            if (ModelState.IsValid)
            {
                taskManager.UpdatedDate = DateTime.Now; // added by Waqar Hassan on 20170926, "to set value of property"
                db.Entry(taskManager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskManager);
        }

        // GET: TaskManagers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskManager taskManager = db.TaskManagers.Find(id);
            if (taskManager == null)
            {
                return HttpNotFound();
            }
            return View(taskManager);
        }

        // POST: TaskManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskManager taskManager = db.TaskManagers.Find(id);
            db.TaskManagers.Remove(taskManager);
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
