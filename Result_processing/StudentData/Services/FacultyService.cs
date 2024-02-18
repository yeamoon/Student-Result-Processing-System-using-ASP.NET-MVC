using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class FacultyService : Service<Faculty>, IFacultyService
    {
        public FacultyService(IRepositoryAsync<Faculty> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
