using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class CourseService : Service<Course>, ICourseService
    {
        public CourseService(IRepositoryAsync<Course> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
