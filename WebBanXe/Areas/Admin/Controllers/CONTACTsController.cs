﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanXe.Model;

namespace WebBanXe.Areas.Admin.Controllers
{
    public class CONTACTsController : Controller
    {
        private DBBanXeEntities db = new DBBanXeEntities();

        // GET: Admin/CONTACTs
        public ActionResult Index()
        {
            var cONTACTs = db.CONTACTs.Include(c => c.USER);
            return View(cONTACTs.ToList());
        }

        // GET: Admin/CONTACTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTACT cONTACT = db.CONTACTs.Find(id);
            if (cONTACT == null)
            {
                return HttpNotFound();
            }
            return View(cONTACT);
        }

        // GET: Admin/CONTACTs/Create
        public ActionResult Create()
        {
            ViewBag.IdUser = new SelectList(db.USERs, "IdUser", "FullName");
            return View();
        }

        // POST: Admin/CONTACTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdContact,IdUser,Title,Email,Content")] CONTACT cONTACT)
        {
            if (ModelState.IsValid)
            {
                db.CONTACTs.Add(cONTACT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdUser = new SelectList(db.USERs, "IdUser", "FullName", cONTACT.IdUser);
            return View(cONTACT);
        }

        // GET: Admin/CONTACTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTACT cONTACT = db.CONTACTs.Find(id);
            if (cONTACT == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdUser = new SelectList(db.USERs, "IdUser", "FullName", cONTACT.IdUser);
            return View(cONTACT);
        }

        // POST: Admin/CONTACTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdContact,IdUser,Title,Email,Content")] CONTACT cONTACT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONTACT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdUser = new SelectList(db.USERs, "IdUser", "FullName", cONTACT.IdUser);
            return View(cONTACT);
        }

        // GET: Admin/CONTACTs/Delete/5
       
        public ActionResult Delete(int id)
        {
            CONTACT cONTACT = db.CONTACTs.Find(id);
            db.CONTACTs.Remove(cONTACT);
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
