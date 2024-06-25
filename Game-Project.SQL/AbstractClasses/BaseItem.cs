namespace Game_Project.SQL.AbstractClasses;

public abstract class BaseItem : BaseEntity
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public double Weight { get; set; }
    public int Value { get; set; }
}
