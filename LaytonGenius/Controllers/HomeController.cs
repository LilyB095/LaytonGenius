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
            // [FIXME] ViewBag.Categories = _appContext.ToList(); where is categories coming from? It isn't a property of appointment
            return View("Create");
        }



        [HttpPost]
        public IActionResult Delete(int a)
        {
            var application = _appContext.Appointments.Single(x => x.AppId == a);
            _appContext.Remove(application);
            _appContext.SaveChanges();
            return RedirectToAction("AppointmentsView");
        }
        
        [HttpGet]
        public IActionResult Edit(int a)
        {
            ViewBag.Responses = _appContext.Appointments.ToList();
            var application = _appContext.Appointments.Single(x => x.AppId == a);
            return View("Create", application);
        }


        [HttpPost]
        public IActionResult Edit(Appointment a)
        {
            _appContext.Update(a);
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