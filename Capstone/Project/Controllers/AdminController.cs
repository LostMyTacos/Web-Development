using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Project.Models;
using Project.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly HITProjectDataEntities DB;
        private UserManager<ApplicationUser> _userManager;
        private IUserValidator<ApplicationUser> _userValidator;
        private IPasswordValidator<ApplicationUser> _passwordValidator;
        private IPasswordHasher<ApplicationUser> _passwordHasher;

        public AdminController(HITProjectDataEntities context, UserManager<ApplicationUser> userManager, IUserValidator<ApplicationUser> userValidator,IPasswordValidator<ApplicationUser> passwordValidator, IPasswordHasher<ApplicationUser> passwordHasher)
        {
            DB = context;
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
        }

        public ViewResult Index()
        {
            List<UserDisplayVM> AppUsers = new List<UserDisplayVM>();

            foreach (ApplicationUser i in _userManager.Users)
            { 
                Facility facility = DB.Facility.Where(x => x.FacilityId == i.FacilityId).FirstOrDefault();
                UserDisplayVM user = new UserDisplayVM
                {
                    UserID = i.Id,
                    FirstName = i.FirstName,
                    LastName = i.LastName,
                    Email = i.Email,
                    Password = i.PasswordHash,
                    FacilityId = facility.FacilityId,
                    FacilityName = facility.FacilityName
                };
                AppUsers.Add(user);
            }
            return View(AppUsers);
        }
            

        public ActionResult AdminPanel()
        {
            return View();
        }

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser { UserName = model.Email, Email = model.Email, FirstName = model.FirstName, LastName = model.LastName, FacilityId = 11};
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {

            ApplicationUser user = await _userManager.FindByIdAsync(id);
            UserDisplayVM EditUser = null;
            //Facility facility = DB.Facility.Where(x => x.FacilityId == user.FacilityId).FirstOrDefault();
            if (user != null)
            {
                Facility facility = DB.Facility.Where(x => x.FacilityId == user.FacilityId).FirstOrDefault();
                //+UserDisplayVM EditUser = new UserDisplayVM
                EditUser = new UserDisplayVM
                {
                    UserID = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.PasswordHash,
                    FacilityId = facility.FacilityId,
                    FacilityName = facility.FacilityName
                };
    
                PopulateFacilityDropDownList(EditUser.FacilityId);
                //+return View(EditUser);
            }
            else
            {
                //+return RedirectToAction("Index");
                ModelState.AddModelError("", "User Not Found");
            }
            return View(EditUser);
        }

        private void PopulateFacilityDropDownList(object selectedFacility = null)
        {
            var facilityQuery = from d in DB.Facility
                             orderby d.FacilityId
                             select d;
            ViewBag.DropDownList = new SelectList(facilityQuery, "FacilityId", "FacilityName", selectedFacility);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserDisplayVM EditUser)
        {
                ApplicationUser user = await _userManager.FindByIdAsync(EditUser.UserID);
                if (user != null)
                {
                    user.FirstName = EditUser.FirstName;
                    user.LastName = EditUser.LastName;
                    user.Email = EditUser.Email;
                    //user.PasswordHash = EditUser.Password;
                    user.FacilityId = EditUser.FacilityId;
                    

                    IdentityResult validEmail = await _userValidator.ValidateAsync(_userManager, user);

                    if (!validEmail.Succeeded)
                    {
                        AddErrorsFromResult(validEmail);
                    }

                    IdentityResult validPassword = null;
                    if (!string.IsNullOrEmpty(EditUser.Password))
                    {
                        validPassword = await _passwordValidator.ValidateAsync(_userManager, user, EditUser.Password);
                        if (validPassword.Succeeded)
                        {
                            user.PasswordHash = _passwordHasher.HashPassword(user, EditUser.Password);
                        }
                        else
                        {
                            AddErrorsFromResult(validPassword);
                        }
                    }
                    if ((validEmail.Succeeded && validPassword == null) || (validEmail.Succeeded && EditUser.Password != string.Empty && validPassword.Succeeded))
                    {
                        IdentityResult result = await _userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            AddErrorsFromResult(result);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User Not Found");
                }           
            return View(EditUser);
        }

        //[HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if(user != null)
            {
                //IdentityResult result = await _userManager.DeleteAsync(user);
                //if (result.Succeeded)
                //{
                //    return RedirectToAction("Index");
                //}
                //else
                //{
                //    AddErrorsFromResult(result);
                //}
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            //return View("Index", _userManager.Users);
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View("Index", _userManager.Users);
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach(IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}