using LaytonGenius.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace LaytonGenius.Controllers
{
    public class HomeController : Controller
    {
        //Contstructor
        private AppointmentContext _appContext { get; set; }
        public HomeController(AppointmentContext appointmentContext)
        {
            _appContext = appointmentContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        //---------------------CRUD-------------------------

        //-------CREATE------- GET
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Responses = _appContext.Appointments.ToList();
            return View(new Appointment());
        }
        //-------CREATE------- POST
        [HttpPost]
        public IActionResult Create(Appointment a)
        {
            if (ModelState.IsValid)
            {
                _appContext.Add(a);
                _appContext.SaveChanges();
                return RedirectToAction("AppointmentsView");
            }
            ViewBag.Categories = _appContext.ToList();
            return View("Create");
        }

        //-------READ-------  GET
        [HttpGet]
        public IActionResult AppointmentsView()
        {
            return View();
        }
    }
}