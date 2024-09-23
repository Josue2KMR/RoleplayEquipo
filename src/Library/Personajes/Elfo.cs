using System;
using Library.Interfaces;

namespace Library
{
    public class Elfo:IPersonaje
    {
        public string Name;
        public IItemAttackValue arma;
        public IItemDefenseValue armadura;
        
        public Elfo(string name, double health,IItemAttackValue arma,IItemDefenseValue armadura)
        {
            this.Name = name;
            this.health = 100;
            this.arma = arma;
            this.armadura = armadura;

        }
        
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public double health { get; set; }

        public double GetAttack()
        {
            Console.WriteLine($"El ataque del elfo {this.Name} es");
            return arma.AttackValue;
        }

        public double GetDefence()
        {
            Console.WriteLine($"La defensa del elfo {this.Name} es ");;
            return armadura.DefenseValue;
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
