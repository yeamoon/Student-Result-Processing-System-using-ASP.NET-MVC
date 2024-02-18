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
    public class TeacherController : Controller
    {
        #region private members
        private readonly ITeacherDataService _teacherDataService;
        private readonly LookupDataService _lookupDataService;
        #endregion
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public TeacherController()
        {
            _teacherDataService = new TeacherDataService();
            _lookupDataService = new LookupDataService();

        }
        public ActionResult TeacherList()

        { 





            try
            {
                 
                var models = _teacherDataService.GetTeachers();
                return View(models);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public ActionResult Teacher(int id)
        {
            var model = id == 0 ? new TeacherViewModel() : _teacherDataService.GetTeacher(id);
            ViewBag.DepartmentId = new SelectList(_lookupDataService.GetDepartments(), "Id", "Name", model.DepartmentId);
            return View(model);

        }
        [HttpPost]
        public ActionResult Teacher(TeacherViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DepartmentId = new SelectList(_lookupDataService.GetDepartments(), "Id", "Name", model.DepartmentId);
                return View(model);
            }
           
            _teacherDataService.Save(model);
            return RedirectToAction("TeacherList");
        }
        public ActionResult Delete(int id)
        {
           
            _teacherDataService.Delete(id);
            return RedirectToAction("TeacherList");
        }

    }
}