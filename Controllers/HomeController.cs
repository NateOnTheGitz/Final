using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        //This is my repository that connects to the database
        //The repository has custom methods like AddEntertainer() and Save() that cause changes in the DBContext stored in the repository
        private IEntertainerRepository _repo { get; set; }

        public HomeController(IEntertainerRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var data = _repo.Entertainers.ToList();

            return View(data);
        }

        public IActionResult Details(int id)
        {
            var record = _repo.Entertainers.Single(x => x.EntertainerID == id);

            return View(record);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Entertainer ENT)
        {
            if(ModelState.IsValid)
            {
                _repo.AddEntertainer(ENT);
                _repo.Save();

                return RedirectToAction("List");
            }
            else
            {
                return View(ENT);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _repo.Entertainers.Single(x => x.EntertainerID == id);

            return View(record);
        }

        [HttpPost]
        public IActionResult Edit(Entertainer ENT)
        {
            if(ModelState.IsValid)
            {
                _repo.EditEntertainer(ENT);
                _repo.Save();

                return RedirectToAction("List");
            }
            else
            {
                return View("Edit", ENT);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = _repo.Entertainers.Single(x => x.EntertainerID == id);

            return View(record);
        }

        [HttpPost]
        public IActionResult Delete(Entertainer ENT)
        {
            _repo.DeleteEntertainer(ENT);
            _repo.Save();

            return RedirectToAction("List");
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
