using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class Weapon : BaseItem
{
    public WeaponType WeaponType { get; set; } = default!;
    public int MinAddedDamage { get; set; }
    public int MaxAddedDamage { get; set; }
    public int MaxHitDamage { get; set; }
    public int CriticalChance { get; set; }

}
