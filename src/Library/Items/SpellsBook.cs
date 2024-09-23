using Library.Interfaces;

namespace Items;

public class SpellsBook:IItemDefenseValue,IItemAttackValue
{
    public Spell[] Spells { get; set; }
    
    public int AttackValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
        set
        {
            
        }
    }

    public int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (Spell spell in this.Spells)
            {
                value += spell.AttackValue;
            }
            return value;
        }
        set
        {
            
        }
    }
}