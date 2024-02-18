using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class TeacherService : Service<Teacher>, ITeacherService
    {
        public TeacherService(IRepositoryAsync<Teacher> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
