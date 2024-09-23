using Library.Interfaces;

namespace Items;

public class Staff:IItemAttackValue,IItemDefenseValue
{
    public int AttackValue
    {
        get
        {
            return AttackValue;
        }
        set
        {
            AttackValue = 100;
        }
    }

    public int DefenseValue
    {
        get
        {
            return DefenseValue;
        }
        set
        {
            DefenseValue = 100;
        }
    }

}