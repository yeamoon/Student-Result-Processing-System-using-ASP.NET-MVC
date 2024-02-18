using System;
using System.ComponentModel.DataAnnotations;

namespace FirstMVCApplication.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }

        [Required,Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int? AddressId { get; set; }

        [Required, Display(Name = "Department")]
        public int DepartmentId { get; set; }
    }
}