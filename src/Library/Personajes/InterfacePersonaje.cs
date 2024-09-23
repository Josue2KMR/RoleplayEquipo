namespace Library.Interfaces;

public interface IPersonaje
{
    double GetAttack();
    double GetDefence();
    void Attack(IPersonaje objetivo);
    void Heal();
    double health { get; set; }
}