using System.ComponentModel.DataAnnotations;
using Game_Project.Common;

namespace Game_Project.SQL
{
    public abstract class BaseEntity : IEntity<int>
    {
        [Key]
        public int Id { get; set; }
    }
}
