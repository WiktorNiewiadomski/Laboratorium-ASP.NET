using Laboratorium_3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    [Authorize]
    public class StorageController : Controller
    {
        private readonly IStorageService _storageService;

        public StorageController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_storageService.FindAll());
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Storage model)
        {
            if (ModelState.IsValid)
            {
                _storageService.Add(model);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            Storage storage = _storageService.FindById(id);

            if (storage != null)
            {
                return View(storage);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(Storage model)
        {
            if (ModelState.IsValid)
            {
                _storageService.Update
                    (model);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {

            if (_storageService.FindById(id) != null)
            {
                return View(_storageService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(Storage model)
        {
            if (ModelState.IsValid)
            {
                _storageService.Delete(model.Id);
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

            if (_storageService.FindById(id) != null)
            {
                return View(_storageService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }
    }
}
