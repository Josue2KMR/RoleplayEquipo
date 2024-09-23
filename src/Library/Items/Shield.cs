using Library.Interfaces;

namespace Items;

public class Shield:IItemDefenseValue
{
    public int DefenseValue { get; set; } = 14;
}