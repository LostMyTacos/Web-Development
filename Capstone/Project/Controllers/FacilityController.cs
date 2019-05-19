using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class FacilityController : Controller
    {
        private readonly HITProjectDataEntities DB;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private ILogger<PatientsController> logger;

        public FacilityController(
            HITProjectDataEntities context,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<PatientsController> log)

        {
            DB = context;
            _userManager = userManager;
            _signInManager = signInManager;
            logger = log;
        }

        // GET: Facilities
        public ActionResult Index()
        {
            List<Facility> Facilities = DB.Facility.ToList();
            List<FacilityType> FacilityTypes = DB.FacilityType.ToList();

            // Initialize Standard Facility
            if(FacilityTypes.Count == 0)
            {
                DB.FacilityType.Add(new FacilityType("Teaching Hospital"));
                DB.FacilityType.Add(new FacilityType("Community Hospital"));
                DB.FacilityType.Add(new FacilityType("Federal Hospital"));
                DB.SaveChanges();
                FacilityTypes = DB.FacilityType.ToList();
                DB.Facility.Add(new Facility("WCTC Healthcare Center", "2019", FacilityTypes[0].FacilityTypeId));
                DB.SaveChanges();
            }
            
            // List Facilities
            return View(DB.Facility.ToList());
        }

        // GET: Facility/Details/?
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                RedirectToAction("Index");
            }
            Facility Facility = DB.Facility.Include("FacilityType").Where(x => x.FacilityId == id).FirstOrDefault();
            if (Facility == null)
            {
                return NotFound();
            }
            if (User.IsInRole("Disabled"))
            {
                ViewBag.isDisabled = true;
            }
            return View(Facility);
        }
        
        // GET: Facility/Create
        public ActionResult Create()
        {
            if (!User.IsInRole("Disabled"))
            {         
                ViewBag.TypeList = UIHelpers.BuildDownDownFromTable(DB, "FacilityType", "TypeDescription", "FacilityTypeId");
                return View();
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }
        
        // POST: Facility/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("FacilityName,FacilityNumber,FacilityType")] Facility NewFacility, IFormCollection Form)
        {
           if (ModelState.IsValid)
               {
                    NewFacility.FacilityTypeId = Int32.Parse(Form["FacilityType"]);
                if (!DB.Facility.Where(x => x.FacilityNumber == NewFacility.FacilityNumber).Any())
                {
                    DB.Facility.Add(NewFacility);
                    DB.SaveChanges();
                }
                else
                {
                    return View(NewFacility);
                }

                return RedirectToAction("Index");
               
            }
            return View(NewFacility);
        }

        // GET: Facility/Edit/?
        public ActionResult Edit(int? id)
        {
            if (!User.IsInRole("Disabled"))
            {
                if (id == null)
                {
                    return BadRequest();
                }

                Facility FacilityRecord = DB.Facility.Include("FacilityType").Where(x => x.FacilityId == id).FirstOrDefault();
                if (FacilityRecord == null)
                {
                    return NotFound();
                }

                FacilityVM EditFacility = new FacilityVM
                {
                    // Facility Table Updates
                    FacilityId = id ?? 0,
                    FacilityNumber = FacilityRecord.FacilityNumber,
                    FacilityName = FacilityRecord.FacilityName,

                    // FacilityType Table Updates
                    FacilityTypeId = FacilityRecord.FacilityTypeId,
                    
                };
                PopulateFacilityTypeDropDownList(FacilityRecord.FacilityTypeId);
                return View(EditFacility);
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
           
        }

        private void PopulateFacilityTypeDropDownList(object selectedFacilityType = null)
        {
            var typesQuery = from d in DB.FacilityType
                             orderby d.FacilityTypeId
                             select d;
            ViewBag.DropDownList = new SelectList(typesQuery, "FacilityTypeId", "TypeDescription", selectedFacilityType);
        }



    // POST: Facility/Edit/?
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(FacilityVM EditFacility)
    {
            if (ModelState.IsValid)
            {
                Facility FacilityRecord = DB.Facility.Include("FacilityType").Where(x => x.FacilityId == EditFacility.FacilityId).FirstOrDefault();
                // Confirm Facility record is in DB
                if (FacilityRecord != null)
                {
                    // Facility Table Updates
                    FacilityRecord.FacilityId = EditFacility.FacilityId;
                    FacilityRecord.FacilityNumber = EditFacility.FacilityNumber;
                    FacilityRecord.FacilityName = EditFacility.FacilityName;

                    // FacilityType Table Updates
                    FacilityRecord.FacilityTypeId = EditFacility.FacilityTypeId;

                    DB.SaveChanges();

                    // For more user info beyond what is supplied by User.Identity
                    var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User)).FirstOrDefault();
                    logger.LogInformation($"User: {UserValues.FirstName} {UserValues.LastName}, edited Facility: {EditFacility.FacilityName} || {EditFacility.FacilityNumber} @ {DateTime.Now}");

                    return RedirectToAction("Index");
                }
            }
            return View(EditFacility);      
    }

        // GET: Facility/Delete/?
        public ActionResult Delete(int? id)
    {
        if (!User.IsInRole("Disabled"))
        {
            if (id == null)
            {
                return BadRequest();
            }
            var Facility = DB.Facility.Include("FacilityType").Where(x => x.FacilityId == id).FirstOrDefault();

            if (Facility == null)
            {
                return NotFound();
            }
            return View(Facility);
        }
        else
        {
            return RedirectToAction("tempError", "Home");
        }
    }

        // POST: Facility/Delete/?
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (!User.IsInRole("Disabled"))
            {
                Facility DeletedFacility = DB.Facility.Where(x => x.FacilityId == id).FirstOrDefault();
                
                DB.Facility.Remove(DeletedFacility);                
                DB.SaveChanges();

                var UserValues = _userManager.Users.Where(x => x.Id == _userManager.GetUserId(User)).FirstOrDefault();
                logger.LogWarning($"User: {UserValues.FirstName} {UserValues.LastName}, Removed Facility: {DeletedFacility.FacilityName} | {DeletedFacility.FacilityNumber} @ {DateTime.Now}");
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("tempError", "Home");
            }
        }
    }
}