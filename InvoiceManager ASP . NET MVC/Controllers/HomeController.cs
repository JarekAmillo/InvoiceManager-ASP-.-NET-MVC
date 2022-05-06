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
                    PaymentDate = DateTime.Now.AddDays(14),
                    Value = 97,
                    Client = new Client {Name = "Klient 1" }
                },
                new Invoice
                {
                    Id = 2,
                    Title = "FA/08/2022",
                    CreatedDate = DateTime.Now,
                    PaymentDate = DateTime.Now.AddDays(14),
                    Value = 157,
                    Client = new Client {Name = "Klient 2" }
                }
        };
            return View(invoices);
        }

        public ActionResult Invoice(int id = 0)
        {
            EditInvoiceViewModel vm = null;

            if (id == 0)
            {
                vm = new EditInvoiceViewModel
                {
                    Clients = new List<Client> { new Client { Id = 1, Name = "Klient 1" } },
                    MethodOfPayments = new List<MethodOfPayment> {
                    new MethodOfPayment { Id = 1, Name = "Przelew" } },
                    Heading = "Dodawanie faktury",
                    Invoice = new Invoice()
                };
            }
            else
            {
                vm = new EditInvoiceViewModel
                {
                    Clients = new List<Client> { new Client { Id = 1, Name = "Klient 1" } },
                    MethodOfPayments = new List<MethodOfPayment> {
                        new MethodOfPayment { Id = 1, Name = "Przelew" } },
                    Heading = "Edycja faktury",
                    Invoice = new Invoice
                    {
                        ClientId = 1,
                        Comments = "uwagi do faktury",
                        CreatedDate = DateTime.Now,
                        PaymentDate = DateTime.Now.AddDays(14),
                        MethodOfPaymentId = 1,
                        Id = 1,
                        Value = 137,
                        Title = "FA/05/2020",
                        InvoicePositions = new List<InvoicePosition>
                    {
                        new InvoicePosition
                        {
                            Id = 1,
                            Lp = 1,
                            Product = new Product { Name = "Produkt 1" },
                            Quantity = 2,
                            Value = 40
                        },

                        new InvoicePosition
                        {
                            Id = 2,
                            Lp = 2,
                            Product = new Product { Name = "Produkt 2" },
                            Quantity = 3,
                            Value = 140
                        },

                    }
                    }
                };
            }
            return View(vm);
        }


        public ActionResult InvoicePosition(int invoiceId, int invoicePositionId = 0)
        {

            EditInvoicePositionViewModel vm = null;

            if (invoicePositionId == 0)
            {
                vm = new EditInvoicePositionViewModel
                {
                    InvoicePosition = new InvoicePosition(),
                    Heading = "Dodawanie nowej pozycji",
                    Products = new List<Product> { new Product { Id = 1, Name = "Produkt 1" } }
                };
            }
            else
            {
                vm = new EditInvoicePositionViewModel
                {
                    InvoicePosition = new InvoicePosition
                    {
                        Lp = 1,
                        Value = 104,
                        Quantity = 3,
                        ProductId = 1
                    },
                    Heading = "Dodawanie nowej pozycji",
                    Products = new List<Product> { new Product { Id = 1, Name = "Produkt 1" } }
                };
            }
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