using Game_Project.SQL.AbstractClasses;
using Game_Project.SQL.Interfaces;

namespace Game_Project.SQL.Entities;

public class Monster : BaseEntity, ICombatStats
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int MinLevel { get; set; }
    public int MaxLevel { get; set; }
    public int ExperienceReward { get; set; }

    public double Health { get; set; }
    public double Endurance { get; set; }
    public double Strength { get; set; }
    public double Intelligence { get; set; }
    public double Dodge { get; set; }
    public double Initiative { get; set; }
    public double Accuracy { get; set; }
    public double CriticalChance { get; set; }
    public double ShieldSkill { get; set; }
}
