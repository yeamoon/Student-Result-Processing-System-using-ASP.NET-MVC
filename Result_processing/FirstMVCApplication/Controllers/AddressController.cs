using FirstMVCApplication.DataServices;
using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveAddress()
        {
            var model = new AddressViewModel
            {
                Street = "13568 spruce st",
                ZipCode = 4567,
                City = "Denver",
                State = "colorado"
            };
            var addressdataservice = new AddressDataService();
            addressdataservice.Save(model);

            return View(model);
        }
    }
}