using Library.Interfaces;

namespace Items;

public class Axe: ItemAttack
{
    public int AttackValue
    {
        get {
            return AttackValue;
        } 
        set {
            AttackValue = value;   
        }
    }
    public int DefenseValue {get;}
}