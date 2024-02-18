using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApplication.DataServices.Interfaces
{
    interface IAddressDataService
    {
        void Save(AddressViewModel model);
    }
}
    