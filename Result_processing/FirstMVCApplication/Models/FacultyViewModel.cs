using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using FirstMVCApplication.Entities;


namespace FirstMVCApplication.Models
{
    public class FacultyViewModel
    {
       public int Id { get; set; }

        [Display(Name = "FacultyName")]
       public  string Name { get; set; }
       
    }
}