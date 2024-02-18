namespace StudentData.Entities
{
    using RepositoryPatternEf6;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Grade")]
    public partial class Grade : Entity
    {
        public Grade()
        {
            Results = new HashSet<Result>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal Marks { get; set; }

        public decimal Point { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}
