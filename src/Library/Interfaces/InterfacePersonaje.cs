namespace Library.Interfaces;

public class IPersonaje
{
    double AttackValue();
    double DefenseValue();
    void Atacar(IPersonaje objetivo, double ataque);
    void Curar(double curacion);
}