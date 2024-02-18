namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Student")]
    public partial class Student : Entity
    {
        public Student()
        {
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string RollNo { get; set; }

        public int? AddressId { get; set; }

        public int? DepartmentId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
