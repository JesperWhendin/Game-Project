namespace Game_Project.Common;

public interface IEntity<T>
{
    T Id { get; set; }
}