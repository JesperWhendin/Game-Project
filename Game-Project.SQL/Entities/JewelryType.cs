using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class JewelryType : BaseEntity
{
    string Name { get; set; } = default!;
}
