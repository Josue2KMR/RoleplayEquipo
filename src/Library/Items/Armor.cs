using Library.Interfaces;

namespace Items;

public class Armor: IItemDefenseValue
{
    public int DefenseValue
    {
        get
        {
            return DefenseValue;
        } 
        set
        {
            DefenseValue = 25;
        }
    }
    
}