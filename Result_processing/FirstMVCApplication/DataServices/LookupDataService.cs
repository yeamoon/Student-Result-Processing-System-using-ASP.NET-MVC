using FirstMVCApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.DataServices
{
    public class LookupDataService
    {
        private readonly StudentContext _context;

        public LookupDataService()
        {
            _context = new StudentContext();
        }

        public IEnumerable<Department> GetDepartments()
        {
            try
            {
                return _context.Departments.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Address> GetAddresses()
        {
            try
            {
                return _context.Addresses.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
