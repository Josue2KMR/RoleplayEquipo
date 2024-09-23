using Library.Interfaces;

namespace Items;

public class Armor:IItemDefenseValue
{
    public int DefenseValue { get; set; }=25;
    
}