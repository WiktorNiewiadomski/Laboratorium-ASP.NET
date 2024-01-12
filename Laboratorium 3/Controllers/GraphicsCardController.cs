using Laboratorium_3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3.Controllers
{
    [Authorize]
    public class GraphicsCardController : Controller
    {
        private readonly IGraphicsCardService _graphicsCardService;

        public GraphicsCardController(IGraphicsCardService graphicsCardService)
        {
            _graphicsCardService = graphicsCardService;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_graphicsCardService.FindAll());
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Create(GraphicsCard model)
        {
            if (ModelState.IsValid)
            {
                _graphicsCardService.Add(model);

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
            GraphicsCard graphicsCard = _graphicsCardService.FindById(id);

            if (graphicsCard != null)
            {
                return View(graphicsCard);
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(GraphicsCard model)
        {
            if (ModelState.IsValid)
            {
                _graphicsCardService.Update
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

            if (_graphicsCardService.FindById(id) != null)
            {
                return View(_graphicsCardService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(GraphicsCard model)
        {
            if (ModelState.IsValid)
            {
                _graphicsCardService.Delete(model.Id);
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

            if (_graphicsCardService.FindById(id) != null)
            {
                return View(_graphicsCardService.FindById(id));
            }
            else
            {
                return NotFound();
            };
        }
    }
}
