using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OldApp.Models;
using OldApp.Models.Adapter;
using OldApp.Models.Target;

namespace OldApp.Controllers
{
    public class HomeController : Controller
    {
        IStudentRepo adapter = new StudentRepo(new BazaDanychContext());
        //BazaDanychContext baza = new BazaDanychContext();
        public IActionResult Index()
        {
            //List<Student> model = new BazaDanychContext().Studenci.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var model = baza.Studenci.Where(s => s.Id == id).FirstOrDefault();
            baza.Studenci.Remove(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            new BazaDanychContext().Studenci.Add(student);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Add()
        {
            return View("Dodaj");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
