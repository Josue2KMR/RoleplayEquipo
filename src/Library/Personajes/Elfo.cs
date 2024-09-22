using System;

namespace Library
{
    public class Elfo
    {
        public string Name;
        public double HealthPoints;
        public Item arma;
        public Item armadura;
        
        public Elfo(string name, double healthpoints,Item arma,Item armadura)
        {
            this.Name = name;
            this.HealthPoints = healthpoints;
            this.arma = arma;
            this.armadura = armadura;

        }
        public double GetAttack()
        {
            Console.WriteLine($"El ataque del elfo {this.Name} es");
            return arma.GetAtaque;
        }

        public double GetDefence()
        {
            Console.WriteLine($"La defensa del elfo {this.Name} es ");;
            return arma.GetDefensa;
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
        
        public void Attack(dwarves enano)
        {
            double attack = GetAttack();
            enano.HealthPoints -= attack;
            if (enano.HealthPoints < 0)
            {
                enano.HealthPoints = 0;
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
}
