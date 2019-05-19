using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Data;
using Project.Helpers;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Controllers
{
    [Authorize]
    public class PatientsController : Controller
    {
        private readonly HITProjectDataEntities DB;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private ILogger<PatientsController> logger;

        public PatientsController(
            HITProjectDataEntities context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<PatientsController> log
            )
        {
            DB = context;
            _userManager = userManager;
            _signInManager = signInManager;
            logger = log;            
        }

        // GET: Patients/
        public IActionResult Index()
        {
            return View(DB.Patient.Include("Person").ToList());
        }

        // GET: Patients/1
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                RedirectToAction("Index");
            }
            Patient Patient = DB.Patient.Include("Person").Where(x => x.PatientId == id).FirstOrDefault();
            if (Patient == null)
            {
                return NotFound();
            }
            List<BirthRecord> Records = DB.BirthRecord.Where(r => r.Prenatal.PatientId == Patient.PatientId).ToList();
            ViewBag.Records = Records;
            if (User.IsInRole("Disabled"))
            {
                ViewBag.isDisabled = true;
            }
            return View(Patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            if (!User.IsInRole("Disabled"))
            {
                //To create a dropdown in view with values from Database.
                //Since not over abusing ViewBag yet, will keep should consider a view model if time permits.
                ViewBag.EducationList = UIHelpers.BuildDownDownFromTable(DB, "EducationEarned", "Name", "EductionEarnedId");
            
                return View();
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: Patients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("FirstName,MiddleName,LastName,Suffix,BirthDate,Education")] Person ThePatient, IFormCollection Form)
        {           
            if (ModelState.IsValid)
            {
                ThePatient.BirthDate = Convert.ToDateTime(Form["birthDate"]);
                ThePatient.Gender = "Female";
                ThePatient.EducationEarnedId = Int32.Parse(Form["Education"]);                

                /* TODO: Adjust RandomNumber to a value range requested by Client.
                Random Random = new Random();
                int RandomNumber = Random.Next(100000, 999999);

                string RandomNumberString = Convert.ToString(RandomNumber);
                List<Patient> Patients = DB.Patient.Where(p => p.MedicalRecordNumber == RandomNumberString).ToList();
                while (Patients.Count > 0)
                {
                    RandomNumber = Random.Next(100000, 999999);
                    RandomNumberString = Convert.ToString(RandomNumber);
                    Patients = DB.Patient.Where(p => p.MedicalRecordNumber == RandomNumberString).ToList();
                }
                */

                ThePatient.Patient.Add(new Patient()
                {
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    MedicalRecordNumber = Form["MedicalRecordNumber"],
                    EditedBy = User.Identity.Name
                });

                // Set race Object to get final value for Person Object
                var PatientRace = new Race
                {
                    Hispanic = null,
                    White = false,
                    Black = false,
                    Indian = false,
                    AsianIndian = false,
                    Chinese = false,
                    Filipino = false,
                    Japanese = false,
                    Korean = false,
                    Vietnamese = false,
                    Hawaiian = false,
                    Guamarian = false,
                    Samoan = false
                };
                    
                if(!DB.Person.Where(x => x.FirstName == ThePatient.FirstName && x.LastName == ThePatient.LastName).Any())
                {
                    DB.Person.Add(ThePatient);
                    DB.SaveChanges();

                    // update PatientRace object with PersonID
                    PatientRace.PersonId = ThePatient.PersonId;
                    DB.Race.Add(PatientRace);
                    DB.SaveChanges();

                }
                else
                {
                    return View(ThePatient);
                }

                logger.LogInformation($"User {User.Identity.Name} created patient: {ThePatient.FirstName} {ThePatient.LastName} Id: {ThePatient.PersonId}");
                //return RedirectToAction("Details/" + DB.Patient.Where(x => x.MedicalRecordNumber == RandomNumber.ToString()).First().PatientId);
                return RedirectToAction("Index");
            }

            return View(ThePatient);
        }

        // GET: Patients/Edit/5
        public IActionResult Edit(int? id)
        {
            if (!User.IsInRole("Disabled"))
            {
                if (id == null)
                {
                    return BadRequest();
                }
                Patient PatientRecord = DB.Patient.Include("Person").Where(x => x.PatientId == id).FirstOrDefault();
                if (PatientRecord == null)
                {
                    return NotFound();
                }
                PatientVM patient = new PatientVM
                {
                    // Patient Table Updates
                    PatientId = id ?? 0,
                    MedicalRecordNumber = PatientRecord.MedicalRecordNumber,

                    // Person Table Updates
                    FirstName = PatientRecord.Person.FirstName,
                    MiddleName = PatientRecord.Person.MiddleName,
                    LastName = PatientRecord.Person.LastName,
                    Suffix = PatientRecord.Person.Suffix,
                    PriorFirstName = PatientRecord.Person.PriorFirstName,
                    PriorMiddleName = PatientRecord.Person.PriorMiddleName,
                    PriorLastName = PatientRecord.Person.PriorLastName,
                    PriorSuffix = PatientRecord.Person.Suffix,
                    Gender = PatientRecord.Person.Gender,
                    ResidentStreetAddress = PatientRecord.Person.ResidentStreetAddress,
                    ResidenceAptNo = PatientRecord.Person.ResidenceAptNo,
                    ResidenceCity = PatientRecord.Person.ResidenceCity,
                    ResidenceState = PatientRecord.Person.ResidenceState,
                    ResidenceZip = PatientRecord.Person.ResidenceZip,
                    Ssn = PatientRecord.Person.Ssn,
                    BirthDate = PatientRecord.Person.BirthDate,
                    Height = PatientRecord.Person.Height,
                    Weight = PatientRecord.Person.Weight,
                    IsMarried = PatientRecord.Person.IsMarried,
                    BirthPlace = PatientRecord.Person.BirthPlace,
                    InCity = PatientRecord.Person.InCity,
                    DateCreated = PatientRecord.DateCreated
                };
                return View(patient);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        // POST: Patients/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientVM patient)
        {
            
            if (ModelState.IsValid)
            {
                var PatientRecord = DB.Patient.Include("Person").Where(x => x.PatientId == patient.PatientId).FirstOrDefault();
                // Confirm Patient record is in DB
                if (PatientRecord != null)
                {
                    // As the Patient spans multiple tables in DB, made a View Model to collect all the required values
                    // Now to distribute that information across EF Navigation Links

                    // Patient Table Updates
                    PatientRecord.MedicalRecordNumber = patient.MedicalRecordNumber;
                    PatientRecord.DateUpdated = DateTime.Now;
                    PatientRecord.EditedBy = User.Identity.Name;

                    // Person Table Updates
                    PatientRecord.Person.FirstName = patient.FirstName;
                    PatientRecord.Person.MiddleName = patient.MiddleName;
                    PatientRecord.Person.LastName = patient.LastName;
                    PatientRecord.Person.Suffix = patient.Suffix;
                    PatientRecord.Person.PriorFirstName = patient.PriorFirstName;
                    PatientRecord.Person.PriorMiddleName = patient.PriorMiddleName;
                    PatientRecord.Person.PriorLastName = patient.PriorLastName;
                    PatientRecord.Person.Suffix = patient.PriorSuffix;
                    PatientRecord.Person.Gender = patient.Gender;
                    PatientRecord.Person.ResidentStreetAddress = patient.ResidentStreetAddress;
                    PatientRecord.Person.ResidenceAptNo = patient.ResidenceAptNo;
                    PatientRecord.Person.ResidenceCity = patient.ResidenceCity;
                    PatientRecord.Person.ResidenceState = patient.ResidenceState;
                    PatientRecord.Person.ResidenceZip = patient.ResidenceZip;
                    PatientRecord.Person.Ssn = patient.Ssn;
                    PatientRecord.Person.BirthDate = patient.BirthDate;
                    PatientRecord.Person.Height = patient.Height;
                    PatientRecord.Person.Weight = patient.Weight;
                    PatientRecord.Person.IsMarried = patient.IsMarried;
                    PatientRecord.Person.BirthPlace = patient.BirthPlace;
                    PatientRecord.Person.InCity = patient.InCity;

                    // TODO: Patient-Race Infomation -- Pending review of how we are handling Race in DB

                    DB.SaveChanges();

                    // For more user info beyond what is supplied by User.Identity
                    var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User)).FirstOrDefault();
                    logger.LogInformation($"User: {UserValues.FirstName} {UserValues.LastName}, edited Patient: {patient.FirstName} {patient.LastName} @ {DateTime.Now}");

                    return RedirectToAction("Index");
                }
            }
            return View(patient);
        }

        //GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (!User.IsInRole("Disabled"))
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var patient = DB.Patient.Include("Person").Where(x => x.PatientId == id).FirstOrDefault();

                if (patient == null)
                {
                    return NotFound();
                }
                return View(patient);
            }
            else
            {
                return RedirectToAction("tempError", "Home");
            }
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (!User.IsInRole("Disabled"))
            {
                Patient patient = DB.Patient.Include("Person").Where(x => x.PatientId == id).FirstOrDefault();
                Person person = DB.Person.Where(x => x.PersonId == patient.PersonId).FirstOrDefault();
                DB.Patient.Remove(patient);
                DB.Person.Remove(person);
                DB.SaveChanges();
                var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User)).FirstOrDefault();
                logger.LogWarning($"User: {UserValues.FirstName} {UserValues.LastName}, edited Patient: {patient.Person.FirstName} {patient.Person.LastName} @ {DateTime.Now}");
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("tempError", "Home");
            }
        }

        //-------------PATIENT LOOKUP----------

        public ActionResult PatientLookup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientLookup(IFormCollection Form)
        {

            string Button = Request.Form["button"];

            switch (Button)
            {
                case "nameSearch":
                    string LastName = Request.Form["lastName"];
                    string DobString = Request.Form["dob"];
                    DateTime Dob = DateTime.Now;
                    if (DobString.Length > 1 && LastName.Length > 1)
                    {
                        Dob = DateTime.Parse(DobString);
                        IEnumerable<Patient> Patients =
                            DB.Patient.Where(p => p.Person.BirthDate == Dob && p.Person.LastName.Contains(LastName)).ToList();
                        if (Patients.Any())
                        {
                            //patient patient = patients.First();
                            //Create cookie
                            //HttpCookie patientCookie = new HttpCookie("patientId", patient.patientId.ToString());
                            //Response.Cookies.Add(patientCookie);
                            ViewBag.searchQuery = "Results matching Last name of " + Request.Form["lastName"] + " and DOB of " + Request.Form["dob"];
                            return View("PatientResults", Patients);
                        }
                        else
                        {
                            //Patient was not found. Go back to search.

                            //Send ViewBag variable with Error message.
                            ViewBag.PatientFound = false;
                            return View();
                        }
                    }
                    else if (LastName.Length > 1)
                    {
                        IEnumerable<Patient> Patients =
                            DB.Patient.Include("Person").Where(p => p.Person.LastName.Contains(LastName)).ToList();
                        //patients = DB.patients.ToList();
                        if (Patients.Any())
                        {
                            //patient patient = patients.First();
                            //Create cookie
                            //HttpCookie patientCookie = new HttpCookie("patientId", patient.patientId.ToString());
                            //Response.Cookies.Add(patientCookie);
                            ViewBag.searchQuery = "Results matching Last name of " + Request.Form["lastName"];
                            return View("PatientResults", Patients);
                        }
                        else
                        {
                            //Patient was not found. Go back to search.

                            //Send ViewBag variable with Error message.
                            ViewBag.PatientFound = false;
                            return View();
                        }
                    }
                    break;
                case "mrnSearch":
                    string Mrn = Request.Form["mrn"];
                    if (Mrn.Length >= 1)
                    {
                        IEnumerable<Patient> Patients =
                            DB.Patient.Include("Person").Where(p => p.MedicalRecordNumber == Mrn).ToList();
                        if (Patients.Any())
                        {
                            //patient patient = patients.First();
                            //Create cookie
                            //HttpCookie patientCookie = new HttpCookie("patientId", patient.patientId.ToString());
                            //Response.Cookies.Add(patientCookie);
                            ViewBag.searchQuery = "Results matching MRN of " + Request.Form["mrn"];
                            return View("PatientResults", Patients);
                        }
                        else
                        {
                            //Patient was not found. Go back to search.

                            //Send ViewBag variable with Error message.
                            ViewBag.PatientFound = false;
                            return View();
                        }
                    }
                    break;
            }
            //Input not filled in.
            return View();
            
        }

        //Results of Patient Lookup
        public ActionResult PatientResults(IEnumerable<Patient> Patients)
        {
            return View(Patients);
        }

        public ActionResult SouvenirForm(int? id)
        {
            // For more user info beyond what is supplied by User.Identity
            var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User)).FirstOrDefault();

            if (id == null)
            {
                return BadRequest();
            }
            Patient Patient = DB.Patient.Find(id);
            if (Patient == null)
            {
                return NotFound();
            }
            List<BirthRecord> Records = DB.BirthRecord.Where(r => r.Prenatal.PatientId == Patient.PatientId).ToList();
            ViewBag.Records = Records;
            //records[0].birthRecord.dateCreated.ToString();
            DateTime Time = DB.BirthRecord.Where(x => x.BirthRecordId == id).FirstOrDefault().NewBorn.First().BirthTime;
            int Weight = 0;
            if (DB.BirthRecord.Where(x => x.BirthRecordId == id).FirstOrDefault().NewBorn.First().BirthWeight != null)
            {
                Weight = (int)DB.BirthRecord.Where(x => x.BirthRecordId == id).FirstOrDefault().NewBorn.First().BirthWeight;
            }
            double Lbs = Weight / 453;
            double Remainder = Weight % 453;
            double Oz = Math.Round(Remainder / 28);
            ViewBag.Weight = Lbs + " pounds " + Oz + " ounces";

            string Date = Time.ToString("M-d-yyyy");
            ViewBag.BirthDate = Date;

            logger.LogInformation($"User {UserValues.FirstName} {UserValues.LastName} generated souviner form for {Patient.Person.FirstName} {Patient.Person.LastName}");

            return View(Patient);
        }
    }
}
