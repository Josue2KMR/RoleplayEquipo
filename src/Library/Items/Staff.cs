using Library.Interfaces;

namespace Items;

public class Staff:IItemAttackValue,IItemDefenseValue
{
    public int AttackValue { get; set; }= 100;
    public int DefenseValue { get; set; }= 100;
    
}