using Game_Project.SQL.AbstractClasses;

namespace Game_Project.SQL.Entities;

public class Character : BaseStats
{
    
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int Gold { get; set; }
    public int TotalWeight { get; set; }

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
