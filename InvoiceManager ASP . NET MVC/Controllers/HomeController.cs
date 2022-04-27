using InvoiceManager_ASP.NET_MVC.Models.Domains;
using InvoiceManager_ASP.NET_MVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceManager_ASP.NET_MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var invoices = new List<Invoice>
            {
                new Invoice
                {
                    Id = 1,
                    Title = "FA/05/2022",
                    CreatedDate = DateTime.Now,
                    PaymentDate = DateTime.Now,
                    Value = 97,
                    Client = new Client {Name = "Klient 1" }
                },
                new Invoice
                {
                    Id = 2,
                    Title = "FA/08/2022",
                    CreatedDate = DateTime.Now,
                    PaymentDate = DateTime.Now,
                    Value = 157,
                    Client = new Client {Name = "Klient 2" }
                }
            };

            return View(invoices);
        }

        public ActionResult Invoice(int id = 0)
        {
            var vm = new EditInvoiceViewModel
            {
                Clients = new List<Client> { new Client { Id = 1, Name = "Klient 1" } },
                MethodOfPayments = new List<MethodOfPayment> { 
                    new MethodOfPayment { Id = 1, Name = "Przelew" } },
                Heading = "Edycja faktury",
                Invoice = new Invoice()
            };
            
            return View(vm);
        }



        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}