using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;

namespace StudentData.Services
{

    public class StudentService : Service<Student>, IStudentService
    {
        public StudentService(IRepositoryAsync<Student> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}

