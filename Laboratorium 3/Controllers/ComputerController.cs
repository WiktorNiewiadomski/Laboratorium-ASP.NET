using Laboratorium_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_3.Controllers
{
    public class ComputerController : Controller
    {
        private readonly IComputerService _computerService;

        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        public IActionResult Index()
        {
            return View(_computerService.FindAll());
        }

        [HttpGet]
        public IActionResult Create() { return View(); }

        [HttpPost]
        public IActionResult Create(Computer model)
        {
            if (ModelState.IsValid)
            {
                _computerService.Add(model);

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

            if (_computerService.FindById(id) != null)
            {
                return View(_computerService.FindById(id));
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
                _computerService.Update(model);
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

            if (_computerService.FindById(id) != null)
            {
                return View(_computerService.FindById(id));
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
                _computerService.Delete(model.Id);
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

            if (_computerService.FindById(id) != null)
            {
                return View(_computerService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }
    }
}
