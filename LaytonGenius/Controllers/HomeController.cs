using LaytonGenius.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        // ------------ FIRST SIGN UP (Times GET and POST) -------------------
        [HttpGet]
        public IActionResult SignUpTimes()
        {
            ViewBag.AvailableTimes = _appContext.AvailableTimes.ToList();

            var application = _appContext.AvailableTimes
                //.Include(x => x.AppId)
                .OrderBy(x => x.Date)
                .ToList();

            return View(application);
        }




        //---------------------CRUD-------------------------




        //-------CREATE------- GET
        [HttpGet]
        public IActionResult Create(int dateid)
        {
            ViewBag.Responses = _appContext.Appointments.ToList();
            Appointment app = new Appointment();
            app.DateID = dateid;
            return View(app);
        }



        //-------CREATE------- POST
        [HttpPost]
        public IActionResult Create(Appointment app)
        {
            if (ModelState.IsValid)
            {
                _appContext.Add(app);
                _appContext.SaveChanges();
                return RedirectToAction("AppointmentsView");
            }
            // [FIXME] ViewBag.Categories = _appContext.ToList(); where is categories coming from? It isn't a property of appointment
            return View("Create");
        }



        [HttpPost]
        public IActionResult Delete(int appid)
        {
            var application = _appContext.Appointments.Single(x => x.AppId == appid);
            _appContext.Remove(application);
            _appContext.SaveChanges();
            return RedirectToAction("AppointmentsView");
        }
        
        [HttpGet]
        public IActionResult Edit(int appid)
        {
            ViewBag.Responses = _appContext.Appointments.ToList();
            var application = _appContext.Appointments.Single(x => x.AppId == appid);
            return View("Create", application);
        }


        [HttpPost]
        public IActionResult Edit(Appointment app)
        {
            _appContext.Update(app);
            _appContext.SaveChanges();
            return RedirectToAction("AppointmentsView");
        }

        //-------READ-------  GET
        [HttpGet]
        public IActionResult AppointmentsView()
        {
            ViewBag.Appointments = _appContext.Appointments.ToList();

            var application = _appContext.Appointments
                //.Include(x => x.AppId)
                .OrderBy(x => x.Name)
                .ToList();

            return View(application);
        }
    }
}