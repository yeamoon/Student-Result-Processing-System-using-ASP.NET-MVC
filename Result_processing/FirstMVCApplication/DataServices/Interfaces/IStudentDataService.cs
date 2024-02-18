using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVCApplication.DataServices
{
    public interface IStudentDataService
    {
        StudentViewModel GetStudent(int id);
        List<StudentViewModel> GetStudents();
        void Save(StudentViewModel model);
        void Delete(int id);
    }
}
