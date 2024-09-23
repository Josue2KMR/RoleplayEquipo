using Library.Interfaces;

namespace Items;

public class Spell:IItemAttackValue
{
    public int AttackValue
    {
        get
        {
            return AttackValue;
        }
        set
        {
            AttackValue = 70;
        }
    }
}