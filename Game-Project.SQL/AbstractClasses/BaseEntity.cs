using System.ComponentModel.DataAnnotations;
using Game_Project.Common.Interfaces;

namespace Game_Project.SQL.AbstractClasses
{
    public abstract class BaseEntity : IEntity<Ulid>
    {
        [Key]
        public Ulid Id { get; set; } = Ulid.NewUlid();
    }
}
