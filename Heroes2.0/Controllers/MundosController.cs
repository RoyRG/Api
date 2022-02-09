using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heroes2._0.Controllers
{
    public class MundosController : Controller
    {
        // GET: MundosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MundosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MundosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MundosController/Create
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

        // GET: MundosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MundosController/Edit/5
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

        // GET: MundosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MundosController/Delete/5
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
