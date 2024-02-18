using AutoMapper;
using FirstMVCApplication.Entities;
using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FirstMVCApplication.DataServices
{
    public class StudentDataService : IStudentDataService
    {
        private readonly StudentContext _context;

        public StudentDataService()
        {
            _context = new StudentContext();
        }

        public StudentViewModel GetStudent(int id)
        {
            var entity = _context.Students.Find(id);
            var model = Mapper.Map<StudentViewModel>(entity);
            return model;
        }

        public List<StudentViewModel> GetStudents()
        {
            var entities = _context.Students.ToList().OrderBy(e => e.FirstName).ThenBy(e => e.LastName);
            var models = Mapper.Map<List<StudentViewModel>>(entities);
            return models;
        }

        public void Save(StudentViewModel model)
        {
            if (model.Id == 0)
            {
                var entity = Mapper.Map<Student>(model);
                _context.Students.Add(entity);
            }
            else
            {
                var entity = _context.Students.Find(model.Id);
               
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.RollNo = model.RollNo;
                entity.DepartmentId = model.DepartmentId;
                entity.AddressId = model.AddressId;
                entity.DateOfBirth = (DateTime)model.DateOfBirth;
               
            }
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Students.Find(id);
            _context.Students.Remove(entity);
            _context.SaveChanges();
        }
    }
}