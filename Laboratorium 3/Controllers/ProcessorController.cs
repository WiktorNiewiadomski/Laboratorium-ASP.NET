using Laboratorium_3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    [Authorize]
    public class ProcessorController : Controller
    {
        private readonly IProcessorService _processorService;

        public ProcessorController(IProcessorService processorService)
        {
            _processorService = processorService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_processorService.FindAll());
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Processor model)
        {
            if (ModelState.IsValid)
            {
                _processorService.Add(model);

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
            Processor processor = _processorService.FindById(id);

            if (processor != null)
            {
                return View(processor);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(Processor model)
        {
            if (ModelState.IsValid)
            {
                _processorService.Update
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

            if (_processorService.FindById(id) != null)
            {
                return View(_processorService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(Processor model)
        {
            if (ModelState.IsValid)
            {
                _processorService.Delete(model.Id);
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

            if (_processorService.FindById(id) != null)
            {
                return View(_processorService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }
    }
}
