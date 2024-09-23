using Library.Interfaces;

namespace Items;

public class Bow:IItemAttackValue
{
    public int AttackValue { get; set; } = 15;
    
}