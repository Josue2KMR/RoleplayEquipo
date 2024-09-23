using Library.Interfaces;

namespace Items;

public class Shield:IItemDefenseValue
{
    public int DefenseValue
    {
        get
        {
            return DefenseValue;
        } 
        set
        {
            DefenseValue = 14;
        }
    }
}