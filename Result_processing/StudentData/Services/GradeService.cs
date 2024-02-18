using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class GradeService : Service<Grade>, IGradeService
    {
        public GradeService(IRepositoryAsync<Grade> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
