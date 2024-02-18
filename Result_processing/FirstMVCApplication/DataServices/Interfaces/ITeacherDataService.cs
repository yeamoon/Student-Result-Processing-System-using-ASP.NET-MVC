using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApplication.DataServices.Interfaces
{
    interface ITeacherDataService
    {
        TeacherViewModel GetTeacher(int id);
        List<TeacherViewModel> GetTeachers();
        void Save(TeacherViewModel model);
        void Delete(int id);
    }
}
