using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWithAjaxCall.Models;
namespace MVCWithAjaxCall.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {
            Person ps = new Person()
            {
                Name = name,
                StartDate = DateTime.Now.ToString()
            };
            return Json(ps);
        }
        // GET: Welcome/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Welcome/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Welcome/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Welcome/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Welcome/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Welcome/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Welcome/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
