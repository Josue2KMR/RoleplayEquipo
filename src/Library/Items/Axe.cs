using Library.Interfaces;

namespace Items;

public class Axe:IItemAttackValue
{
    public int AttackValue
    {
        get
        {
            return AttackValue;
        }
        set
        {
            AttackValue = 25;
        }
    }
}