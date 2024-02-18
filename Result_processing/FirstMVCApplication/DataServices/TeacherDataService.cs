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
    public class TeacherDataService:ITeacherDataService
    {
        private readonly StudentContext _context;

        public TeacherDataService()
        {
            _context = new StudentContext();
        }

        public TeacherViewModel GetTeacher(int id)
        {
            var entity = _context.Teachers.Find(id);
            var model = Mapper.Map<TeacherViewModel>(entity);
            return model;

        }
        public List<TeacherViewModel> GetTeachers()
        {
            var entities = _context.Teachers.ToList();
            var models = Mapper.Map<List<TeacherViewModel>>(entities);
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