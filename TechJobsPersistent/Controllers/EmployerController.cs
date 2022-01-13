using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {


        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.employers = context.Employers.ToList();
            return View();
        }

        public IActionResult Add()
        {

            AddEmployerViewModel model = new AddEmployerViewModel();
            return View(model);
        }

        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location,

                };

                context.Employers.Add(employer);
                context.SaveChanges();
                ViewBag.title = "All Categories";
                List<Employer> employers = context.Employers.ToList();


                return View("Index", employers);
            }

            ViewBag.employers = context.Employers.ToList();
            return View();
        }
    

        public IActionResult About(int id)
        {
            return View();
        }
    }
}
