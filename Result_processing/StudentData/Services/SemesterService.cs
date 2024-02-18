using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class SemesterService : Service<Semester>, ISemesterService
    {
        public SemesterService(IRepositoryAsync<Semester> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
