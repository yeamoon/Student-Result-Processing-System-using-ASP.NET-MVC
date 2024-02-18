using FirstMVCApplication.DataServices;
using FirstMVCApplication.DataServices.Interfaces;
using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class FacultyController : Controller
    {
        #region private members
        private readonly IFacultyDataService _facultyDataService;
        private readonly LookupDataService _lookupDataService;
        #endregion
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public FacultyController()
        {
            _facultyDataService = new FacultyDataService();
            _lookupDataService = new LookupDataService();

        }
        public ActionResult FacultyList()
        {
            try
            {

                var models = _facultyDataService.GetFaculty();
                return View(models);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }
}