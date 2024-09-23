using Library.Interfaces;

namespace Items;

public class Helmet:IItemDefenseValue
{
    public int DefenseValue
    {
        get
        {
            return DefenseValue;
        } 
        set
        {
            DefenseValue = 18;
        }
    }
}