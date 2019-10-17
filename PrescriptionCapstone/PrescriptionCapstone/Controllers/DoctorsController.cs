using Newtonsoft.Json.Linq;
using PrescriptionCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
            return View();
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctors/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Doctors/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Doctors/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Presciption REST API
        public ActionResult DisplayAllMedication()
        {
            var requestUrl = $"https://localhost:44315/api/Medications";
            var result = new WebClient().DownloadString(requestUrl);
            var jo = JArray.Parse(result);

            List<MedicationViewModel> ListOfMedication = new List<MedicationViewModel>();

            for (int i = 0; i < jo.Count; i++)
            {
                MedicationViewModel medication = new MedicationViewModel();

                medication.Id = Convert.ToInt32(jo[i]["Id"]);
                medication.Name = jo[i]["Name"].ToString();
                medication.Description = jo[i]["Description"].ToString();
                medication.SideEffect = jo[i]["SideEffect"].ToString();
                medication.TimeOfDay = jo[i]["TimeOfDay"].ToString();
                medication.Treatment = jo[i]["Treatment"].ToString();

                ListOfMedication.Add(medication);
            }
            return View(ListOfMedication);
        }
    }
}
