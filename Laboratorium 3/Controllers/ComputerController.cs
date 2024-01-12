using Laboratorium_3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3.Controllers
{
    [Authorize]
    public class ComputerController : Controller
    {
        private readonly IComputerService _computerService;

        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_computerService.FindAll());
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create() {
            Computer model = new Computer();
            PopulateComuterSelectLists(ref model);
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Computer model)
        {
            if (ModelState.IsValid)
            {
                _computerService.Add(model);

                return RedirectToAction("Index");
            }
            else
            {
                PopulateComuterSelectLists(ref model);
                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            Computer computer = _computerService.FindById(id);

            if (computer != null)
            {
                PopulateComuterSelectLists(ref computer);
                return View(computer);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(Computer model)
        {
            if (ModelState.IsValid)
            {
                _computerService.Update
                    (model);
                return RedirectToAction("Index");
            }
            else
            {
                PopulateComuterSelectLists(ref model);
                return View(model);
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
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
        [Authorize(Roles = "admin")]
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

        private void PopulateComuterSelectLists(ref Computer computer)
        {
            computer.Processors = ListOfProcessors();
            computer.Storages = ListOfStorages();
            computer.GraphicsCards = ListOfGraphicsCards();
        }

        private List<SelectListItem> ListOfProcessors()
        {
            return _computerService
                .FindAllProcessorsForViewModel()
                .Select(p => new SelectListItem() { Value = p.Id.ToString(), Text = p.Name})
                .ToList();
        }

        private List<SelectListItem> ListOfStorages()
        {
            return _computerService
                .FindAllStoragesForViewModel()
                .Select(s => new SelectListItem() { Value = s.Id.ToString(), Text = s.Name })
                .ToList();
        }

        private List<SelectListItem> ListOfGraphicsCards()
        {
            return _computerService
                .FindAllGraphicsCardsForViewModel()
                .Select(gc => new SelectListItem() { Value = gc.Id.ToString(), Text = gc.Name })
                .ToList();
        }
    }
}
