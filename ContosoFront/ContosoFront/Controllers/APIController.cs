using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoFront.Controllers
{
    public class APIController : Controller
    {
        private ContosoAPI contosoAPI = new ContosoAPI();

        // GET: API
        public ActionResult Index()
        {
            ViewBag.Message = "This is Contoso's API dump.";
            ViewBag.Items = contosoAPI.GetAll();

            return View();
        }

        // POST: API/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var formKey = collection["formKey"];
                var formValue = collection["formValue"];

                var returnObj = this.contosoAPI.Create(formKey + " || " + formValue);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: API/Edit
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                var formKey = collection["formKey"];
                var formValue = collection["formValue"];

                var returnObj = this.contosoAPI.Update(formKey, formValue);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: API/Delete/5
        public ActionResult Delete(int id)
        {
            int iterator = 0;

            var items = contosoAPI.GetAll();

            foreach(var item in items)
            {
                if(iterator == id)
                {
                    contosoAPI.Delete(item.Split(new string[]{ @" || "}, StringSplitOptions.None)[0].Trim());
                    break;
                }
                iterator++;
            }

            return RedirectToAction("Index");
        }
    }
}
