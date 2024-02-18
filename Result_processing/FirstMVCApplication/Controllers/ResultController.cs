using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCApplication.Entities;
using FirstMVCApplication.Models;

namespace FirstMVCApplication.Controllers
{
    public class ResultController : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: Result
        public ActionResult RsultList()
        {
            return View(db.ResultViewViewModels.ToList());
        }

        // GET: Result/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultViewViewModel resultViewViewModel = db.ResultViewViewModels.Find(id);
            if (resultViewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(resultViewViewModel);
        }

        // GET: Result/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Result/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,CourseId,SemesterId,GradeId")] ResultViewViewModel resultViewViewModel)
        {
            if (ModelState.IsValid)
            {
                db.ResultViewViewModels.Add(resultViewViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(resultViewViewModel);
        }

        // GET: Result/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultViewViewModel resultViewViewModel = db.ResultViewViewModels.Find(id);
            if (resultViewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(resultViewViewModel);
        }

        // POST: Result/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,CourseId,SemesterId,GradeId")] ResultViewViewModel resultViewViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(resultViewViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(resultViewViewModel);
        }

        // GET: Result/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResultViewViewModel resultViewViewModel = db.ResultViewViewModels.Find(id);
            if (resultViewViewModel == null)
            {
                return HttpNotFound();
            }
            return View(resultViewViewModel);
        }

        // POST: Result/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResultViewViewModel resultViewViewModel = db.ResultViewViewModels.Find(id);
            db.ResultViewViewModels.Remove(resultViewViewModel);
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
