using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class ResultService : Service<Result>, IResultService
    {
        public ResultService(IRepositoryAsync<Result> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
