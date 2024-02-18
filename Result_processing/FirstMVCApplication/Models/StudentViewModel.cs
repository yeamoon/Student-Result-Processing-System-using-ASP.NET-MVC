using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using FirstMVCApplication.Entities;

namespace FirstMVCApplication.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? DateOfBirth { get; set; }

        [Required, Display(Name = "Roll Number")]
        public string RollNo { get; set; }

        [Display(Name = "City")]
        public int? AddressId { get; set; }

        [Display(Name = "State")]
        
        public int? AddressId1 { get; set; }

     

        [Required, Display(Name = "Department")]
        public int DepartmentId { get; set; }
    }
}