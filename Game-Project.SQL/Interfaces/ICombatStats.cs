namespace Game_Project.SQL.Interfaces;

public interface ICombatStats
{
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
