using Library.Interfaces;

namespace Items;

public class Bow:IItemAttackValue
{
    public int AttackValue
    {
        get
        {
            return AttackValue;
        }
        set
        {
            AttackValue = 15;
        }
    }
    
}