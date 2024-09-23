using Library.Interfaces;

namespace Items;

public class Helmet:IItemDefenseValue
{
    public int DefenseValue { get; set; }= 18;
}