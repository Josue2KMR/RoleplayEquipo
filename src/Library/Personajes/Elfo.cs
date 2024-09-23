using System;
using Library.Interfaces;

namespace Library
{
    public class Elfo:IPersonaje
    {
        public string Name;
        public Item arma;
        public Item armadura;
        
        public Elfo(string name, double health,Item arma,Item armadura)
        {
            this.Name = name;
            this.health = 100;
            this.arma = arma;
            this.armadura = armadura;

        }

        public double health { get; set; }

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
        
        public void Attack(IPersonaje objetivo)
        {
            double attack = GetAttack();
            objetivo.health -= attack;
            if (objetivo.health < 0)
            {
                objetivo.health = 0;
            }
        }
        public void Heal()
        {
            if (health <= 100 && health > 75)
            {
                health += health * 0.25;
            }
            else if (health <= 75 && health > 50)
            {
                health += health * 0.50;
            }
            else if (health <= 50)
            {
                health = 150; 
            }
        }

       
    }
}
