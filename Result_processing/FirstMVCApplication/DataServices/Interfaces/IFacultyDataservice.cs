using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApplication.DataServices.Interfaces
{
    interface IFacultyDataService
    {
       
        List<FacultyViewModel> GetFaculty();
        
    }
}
