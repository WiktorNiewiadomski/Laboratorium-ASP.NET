using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_3.Controllers
{
    public class ComputerController : Controller
    {
        static Dictionary<int, Computer> _computers = new Dictionary<int, Computer>();

        public IActionResult Index()
        {
            return View(_computers);
        }

        [HttpGet]
        public IActionResult Create() { return View(); }

        [HttpPost]
        public IActionResult Create(Computer model)
        {
            if (ModelState.IsValid)
            {
                int id = _computers.Keys.Count != 0 ? _computers.Keys.Max() : 0;
                model.Id = id + 1;
                _computers.Add(model.Id, model);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            if (_computers.Keys.Contains(id))
            {
                return View(_computers[id]);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult Edit(Computer model)
        {
            if (ModelState.IsValid)
            {
                _computers[model.Id] = model;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            if (_computers.Keys.Contains(id))
            {
                return View(_computers[id]);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        public IActionResult Delete(Computer model)
        {
            if (ModelState.IsValid)
            {
                _computers.Remove(model.Id);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            if (_computers.Keys.Contains(id))
            {
                return View(_computers[id]);
            }
            else
            {
                return NotFound();
            };
        }
    }
}
