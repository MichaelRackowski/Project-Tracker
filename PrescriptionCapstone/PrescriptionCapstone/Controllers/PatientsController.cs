﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrescriptionCapstone.Models;

namespace PrescriptionCapstone.Controllers
{
    public class PatientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Patients
        public ActionResult Index()
        {
            var patients = db.Patients.Include(p => p.ApplicationUser);
            return View(patients.ToList());
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationId = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,Diagnosis,ScheduledAppointment,ApplicationId")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicationId = new SelectList(db.ApplicationUsers, "Id", "Email", patient.ApplicationId);
            return View(patient);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationId = new SelectList(db.ApplicationUsers, "Id", "Email", patient.ApplicationId);
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,Diagnosis,ScheduledAppointment,ApplicationId")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationId = new SelectList(db.ApplicationUsers, "Id", "Email", patient.ApplicationId);
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
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
        /*public ActionResult SelectAppointment()
        {
            var confirmedAppt = db.Doctors.
        }*/   //####### create after doctor's control is done.

        /*public ActionResult SelectMedication()
        {
            //view list from MD 
            //select medication
            //store selected option in a variable 
            //notify MD??
        }*/
        public ActionResult ConfirmTakeMed(string patientConfirmation)
        {
            if (patientConfirmation == "ok")
            {
                return View("Medication Taken");
            }
            if (patientConfirmation != "ok")
            {
                return View("Missed Medication");
            }

            return RedirectToAction("Index");
        }
        public void Log(int Id, string text)
        {
            var patientLog = db.Patients.Find(Id);
            DateTime dt = DateTime.Now;

            if (patientLog == db.Patients.Id) ;
            return View(patientLog, text);
        }
    }
}
