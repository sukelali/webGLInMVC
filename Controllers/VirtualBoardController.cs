using Microsoft.AspNetCore.Mvc;

namespace WebGLinMVC.Controllers
{

    public class VirtualBoardController : Controller
    {

        private readonly IWebHostEnvironment _hostEnvironment;

        public VirtualBoardController(IWebHostEnvironment hostEnvironment) { 
            
            _hostEnvironment = hostEnvironment;
        }




        // GET: VirtualBoardController
        [HttpGet]
        public ActionResult Index()
        {

            return View();

        }

        // GET: VirtualBoardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VirtualBoardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VirtualBoardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VirtualBoardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VirtualBoardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VirtualBoardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VirtualBoardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
