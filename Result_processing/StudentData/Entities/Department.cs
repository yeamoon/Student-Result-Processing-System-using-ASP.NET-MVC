namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Department")]
    public partial class Department : Entity
    {
        public Department()
        {
            Courses = new HashSet<Course>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int FacultyId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
