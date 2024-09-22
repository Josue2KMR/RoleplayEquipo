using System;
namespace Library;

public class dwarves
{
    public string Name;
    public double HealthPoints;
    public Item arma;
    public Item armadura;
    
    public dwarves(string name, double hp,Item arma,Item armadura)
    {
        this.Name = name;
        this.HealthPoints = hp+armadura.GetDefensa;
        this.arma = arma;
        this.armadura = armadura;

    }
    public double GetAttack()
    {
         Console.WriteLine($"El ataque del enano {this.Name} es");
         return arma.GetAtaque;
    }
    public double GetDefence()
    {
        Console.WriteLine($"La defensa del enano {this.Name} es ");;
        return armadura.GetDefensa;
    }
    

    public void Attack(Wizard wizard)
    {
        double attack = GetAttack();
            wizard.HealthPoints -= attack;
            if (wizard.HealthPoints < 0)
            {
                wizard.HealthPoints = 0;
            }
    }

    public void Attack(Elfo elfo)
    {
        double attack = GetAttack();
        elfo.HealthPoints -= attack;
        if (elfo.HealthPoints < 0)
        {
            elfo.HealthPoints = 0;
        }
    }

    public void Heal()
    {
        if (HealthPoints <= 100 && HealthPoints > 75)
        {
            HealthPoints += HealthPoints * 0.25;
        }
        else if (HealthPoints <= 75 && HealthPoints > 50)
        {
            HealthPoints += HealthPoints * 0.50;
        }
        else if (HealthPoints <= 50)
        {
            HealthPoints = 150; 
        }
    }
}