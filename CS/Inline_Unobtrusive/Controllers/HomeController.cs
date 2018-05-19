using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Inline_Unobtrusive.Models;

namespace Inline_Unobtrusive.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(GetData());
        }

        public ActionResult GridViewPartial() {
            return PartialView(GetData());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult InlineEditingAddNewPartial(Customer customer) {
            if (ModelState.IsValid) {
                try {
                    //insert data in the data source
                } catch (Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            } else {
                ViewData["EditError"] = "Please, correct all errors.";
            }
            return PartialView("GridViewPartial", GetData());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult InlineEditingUpdatePartial(Customer customer) {
            if (ModelState.IsValid) {
                try {
                    //update data in the data source
                } catch (Exception e) {
                    ViewData["EditError"] = e.Message;
                }
            } else {
                ViewData["EditError"] = "Please, correct all errors.";
            }
            return PartialView("GridViewPartial", GetData());
        }

        public static IEnumerable<Customer> GetData() {
            return Enumerable.Range(0, 10).Select(i => new Customer() { ID = i, City = "City " + i, Name = "Customer " + i });
        }
    }

}