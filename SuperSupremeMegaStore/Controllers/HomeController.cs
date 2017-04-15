using SuperSupremeMegaStore.DAL;
using SuperSupremeMegaStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperSupremeMegaStore.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<PurchaseDateGroup> data = from customer in db.Customers
                                                   group customer by customer.LastPurchase  into dateGroup
                                                   select new PurchaseDateGroup()
                                                   {
                                                       PurchaseDateInfo = dateGroup.Key,
                                                       PurchaseCount = dateGroup.Count()
                                                   };
            return View(data.ToList());

            IQueryable<PurchaseDateGroup> info = from employee in db.Employees
                                                 group employee by employee.HireDate into dateGroup
                                                 select new PurchaseDateGroup ()
                                                 {
                                                       EmployeeStartDateInfo = dateGroup.Key,
                                                       EmployeeCount = dateGroup.Count()                        
                                                 };
            return View(info.ToList());

        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}