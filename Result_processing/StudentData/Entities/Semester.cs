namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Semester")]
    public partial class Semester : Entity
    {
        public Semester()
        {
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }

        public int Term { get; set; }

        public int Year { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
