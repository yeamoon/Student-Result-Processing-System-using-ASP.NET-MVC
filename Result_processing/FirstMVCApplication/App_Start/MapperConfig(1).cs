using AutoMapper;
using FirstMVCApplication.Entities;
using FirstMVCApplication.Models;

namespace FirstMVCApplication
{
    public class MapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(m =>
            {
                m.CreateMap<Student, StudentViewModel>().ReverseMap();
                m.CreateMap<Teacher, TeacherViewModel>().ReverseMap();
                m.CreateMap<Faculty, FacultyViewModel>().ReverseMap();

            });
        }
    }
}