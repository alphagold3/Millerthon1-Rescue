using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rescue.Controllers
{
    public class WizardController : Controller
    {
        // GET: Wizard
        public ActionResult Index()
        {
            return View();
        }

        // GET: Wizard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Wizard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wizard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Wizard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wizard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Wizard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wizard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}