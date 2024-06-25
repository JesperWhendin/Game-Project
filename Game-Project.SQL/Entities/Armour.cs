using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class Armour : BaseItem
{
    public ArmourType EquipmentSlot { get; set; } = default!;

    public int? DamageAbsorption { get; set; }
    public double? DamageReduction { get; set; }
}
