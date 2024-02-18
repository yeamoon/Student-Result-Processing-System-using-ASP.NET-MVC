namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Result")]
    public partial class Result : Entity
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public int SemesterId { get; set; }

        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual Course Course { get; set; }
    }
}
