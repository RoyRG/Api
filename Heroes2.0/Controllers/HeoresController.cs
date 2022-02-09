using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Heroes2._0.Controllers
{
    public class HeoresController : Controller
    {
        // GET: HeoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HeoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeoresController/Create
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

        // GET: HeoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeoresController/Edit/5
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

        // GET: HeoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeoresController/Delete/5
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
