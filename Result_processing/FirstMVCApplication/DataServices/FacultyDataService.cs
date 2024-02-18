using AutoMapper;
using FirstMVCApplication.DataServices.Interfaces;
using FirstMVCApplication.Entities;
using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.DataServices
{
    public class FacultyDataService:IFacultyDataService
    {
        private readonly StudentContext _context;

        public FacultyDataService()
        {
            _context = new StudentContext();
        }

        public FacultyViewModel GetFaculty(int id)
        {
            var entity = _context.Faculties.Find(id);
            var model = Mapper.Map<FacultyViewModel > (entity);
            return model;

        }
        public List<FacultyViewModel> GetFaculty()
        {
            var entities = _context.Faculties.ToList();
            var models = Mapper.Map<List<FacultyViewModel>>(entities);
            return models;
        }
        public void Save(TeacherViewModel model)
        {
            if (model.Id == 0)
            {
                var entity = Mapper.Map<Teacher>(model);
                _context.Teachers.Add(entity);
            }
            else
            {
                var entity = _context.Teachers.Find(model.Id);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.DepartmentId = model.DepartmentId;


            }
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = _context.Teachers.Find(id);
            _context.Teachers.Remove(entity);
            _context.SaveChanges();
        }

    }
}