using Library.Interfaces;

namespace Items;

public class Axe:IItemAttackValue
{
    public int AttackValue { get; set; }= 25;
}