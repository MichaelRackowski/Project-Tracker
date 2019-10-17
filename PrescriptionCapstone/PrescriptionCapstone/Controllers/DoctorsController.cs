using Microsoft.AspNet.Identity;
using PrescriptionCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PrescriptionCapstone.Controllers
{
    public class DoctorsController : Controller
    {
        ApplicationDbContext context;

        public DoctorsController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Doctors
        public ActionResult Index()
        {
            var doctorId = User.Identity.GetUserId();
            Doctor doctor = context.Doctors.Where(d => d.UserId == doctorId).SingleOrDefault();
            var listofPatients = context.Patients.Where(p => p.DoctorId == doctor.Id).ToList();
            return View(listofPatients);
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            Doctor doctor = new Doctor();
            return View(doctor);
        }

        // POST: Doctors/Create
        [HttpPost]
        public ActionResult Create(Doctor doctor)
        {
            try
            {
                var user = User.Identity.GetUserId();
                doctor.UserId = user;
                context.Doctors.Add(doctor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int id)
        {
            Doctor doctor = context.Doctors.Where(d => d.Id == id).SingleOrDefault();
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Doctor doctor)
        {
            try
            {
                Doctor editDoctor = context.Doctors.Find(id);
                editDoctor.FirstName = doctor.FirstName;
                editDoctor.LastName = doctor.LastName;
                editDoctor.EmailAddress = doctor.EmailAddress;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int id)
        {
            Doctor RemoveDoc = context.Doctors.Where(d => d.Id == id).SingleOrDefault();
            return View(RemoveDoc);
        }

        // POST: Doctors/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Doctor doctor)
        {
            try
            {
                context.Doctors.Remove(context.Doctors.Find(id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ViewPatientLog(int id, Patient patient)
        {
            patient = context.Patients.Where(p => p.Id == id).SingleOrDefault();

            return RedirectToAction("patientLog", "Patients");
        }

    }
}
