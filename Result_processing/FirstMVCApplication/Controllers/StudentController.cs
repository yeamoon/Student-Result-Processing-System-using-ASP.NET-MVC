using FirstMVCApplication.DataServices;
using FirstMVCApplication.Models;
using System;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        #region Private Members
        private readonly IStudentDataService _studentDataService;
        private readonly LookupDataService _lookupDataService;
        #endregion

        #region Constructors
        public StudentController()
        {
            _studentDataService = new StudentDataService();
            _lookupDataService = new LookupDataService();
        }
        #endregion

        #region Public Methods

        public ActionResult Student(int id)
        {
            
            var model = id == 0 ? new StudentViewModel() : _studentDataService.GetStudent(id);
            ViewBag.DepartmentId = new SelectList(_lookupDataService.GetDepartments(), "Id", "Name", model.DepartmentId);
        
            ViewBag.AddressId = new SelectList(_lookupDataService.GetAddresses(), "Id", "City", model.AddressId);
            ViewBag.AddressId1 = new SelectList(_lookupDataService.GetAddresses(),
                                           "Id",
                                           "State",
                                           model.AddressId1);
            return View(model);
        }

        public ActionResult StudentList()
        {
            try
            {
                var models = _studentDataService.GetStudents();
                return View(models);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Student(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                
                
                ViewBag.DepartmentId = new SelectList(_lookupDataService.GetDepartments(), "Id", "Name", model.DepartmentId);
                ViewBag.AddressId = new SelectList(_lookupDataService.GetAddresses(), "Id", "City", model.AddressId);
                ViewBag.AddressId1 = new SelectList(_lookupDataService.GetAddresses(), "Id", "State", model.AddressId1);

                return View(model);
                
            }

            _studentDataService.Save(model);
            return RedirectToAction("StudentList");
        }

        public ActionResult Delete(int id)
        {
            _studentDataService.Delete(id);
            return RedirectToAction("StudentList");
        }
        #endregion

        #region Private Methods
        #endregion
    }
}