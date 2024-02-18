using FirstMVCApplication.DataServices.Interfaces;
using FirstMVCApplication.Entities;
using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.DataServices
{
    public class AddressDataService : IAddressDataService
    {
        public void Save(AddressViewModel model)
        {
            var context = new StudentContext();
            var entity = new Address
            {
                Street = model.Street,
                ZipCode = model.ZipCode,
                City = model.City,
                State = model.State
            };

            context.Addresses.Add(entity);
            context.SaveChanges();



        }
    }
}