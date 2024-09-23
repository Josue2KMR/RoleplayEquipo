using Library.Interfaces;

namespace Items;

public class Spell:IItemAttackValue
{
    public int AttackValue { get; set; }= 70;
    public int DefenseValue { get; set; } = 0;
}