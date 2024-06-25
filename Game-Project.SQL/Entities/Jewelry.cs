using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class Jewelry : BaseItem
{
    public JewelryType EquipmentSlot { get; set; } = default!;

    public int? AddedHealth { get; set; }
    public double? IncreasedHealth { get; set; }
    public int? AddedEndurance { get; set; }
    public double? IncreasedEndurance { get; set; }
    public int? AddedStrength { get; set; }
    public double? IncreasedStrength { get; set; }
    public int? AddedIntelligence { get; set; }
    public double? IncreasedIntelligence { get; set; }
    public int? AddedDodge { get; set; }
    public double? IncreasedDodge { get; set; }
    public int? AddedInitiative { get; set; }
    public double? IncreasedInitiative { get; set; }
    public int? AddedAccuracy { get; set; }
    public double? IncreasedAccuracy { get; set; }
    public int? AddedCriticalChance { get; set; }
    public double? IncreasedCriticalChance { get; set; }
    public int? AddedShieldSkill { get; set; }
    public double? IncreasedShieldSkill { get; set; }
}
