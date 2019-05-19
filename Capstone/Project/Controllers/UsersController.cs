using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    public class UsersController : Controller
    {
        private readonly HITProjectDataEntities Db;
        private ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private ILogger<UsersController> logger;

        public UsersController(
            HITProjectDataEntities context,
            ApplicationDbContext applicationDbContext,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager,
        ILogger<UsersController> log)
        {
            Db = context;
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            logger = log;
        }

        public ActionResult AdminPanel()
        {
            return View();
        }
    }
}