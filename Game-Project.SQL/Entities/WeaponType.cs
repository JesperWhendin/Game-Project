using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class WeaponType : BaseEntity
{
    public string Name { get; set; } = default!;
}
