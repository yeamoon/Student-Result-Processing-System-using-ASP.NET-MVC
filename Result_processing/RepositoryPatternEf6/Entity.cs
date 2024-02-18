using System.ComponentModel.DataAnnotations.Schema;
using RepositoryPattern.Infrastructure;

namespace RepositoryPatternEf6
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}