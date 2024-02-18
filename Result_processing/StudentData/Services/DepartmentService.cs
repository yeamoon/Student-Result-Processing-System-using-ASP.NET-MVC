using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        public DepartmentService(IRepositoryAsync<Department> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
