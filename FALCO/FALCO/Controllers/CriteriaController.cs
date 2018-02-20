using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FALCO.Controllers
{
    public class CriteriaController : Controller
    {
        // GET: Criteria
        public ActionResult Index()
        {
            return View();
        }

        // GET: Criteria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Criteria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Criteria/Create
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

        // GET: Criteria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Criteria/Edit/5
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

        // GET: Criteria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Criteria/Delete/5
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
