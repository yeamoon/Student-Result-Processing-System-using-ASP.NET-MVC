using RepositoryPattern.Repositories;
using RepositoryPattern.UnitOfWork;
using ServicePattern;
using StudentData.Entities;
using StudentData.Interfaces;
namespace StudentData.Services
{
    public class AddressService : Service<Address>, IAddressService
    {
        public AddressService(IRepositoryAsync<Address> repository, IUnitOfWorkAsync unitOfWork) : base(repository, unitOfWork) { }
    }
}
