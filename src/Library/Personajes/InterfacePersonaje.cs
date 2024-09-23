namespace Library.Interfaces;

public interface IPersonaje:IItemAttackValue,IItemDefenseValue
{
    double GetAttack();
    double GetDefence();
    void Attack(IPersonaje objetivo);
    void Heal();
    double health { get; set; }
}