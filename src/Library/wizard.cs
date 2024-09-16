using System;

namespace Library;

public class wizard
{
    // Atributos del mago
    public string Name;
    public double HealthPoints = 100;
    public Item WeaponDamage;
    public Item ArmorDamage;
    public LibroDeHechizos SpellBook;
    
    // Constructor
    public wizard(string name, double hp, LibroDeHechizos spellBook, Item armorDamage, Item weaponDamage)
    {
        this.Name = name;
        this.HealthPoints = hp + armorDamage.GetDefensa;
        this.SpellBook = spellBook;
        this.ArmorDamage = armorDamage;
        this.WeaponDamage = weaponDamage;
    }
    

    // Métodos del mago
    public List<string> ListaDeHechizos()
    {
        return SpellBook.GetListaHechizos;
    }

    public int Conocimiento()
    {
        return SpellBook.GetConocimiento;
    }
    
    public double GetAttack()
    {
        if (WeaponDamage == null || WeaponDamage.GetDefensa == 0)
        {
            Console.WriteLine($"El ataque del Mago {this.Name} es");
            return 10;
        }
        else
        {
            Console.WriteLine($"El ataque del Mago {this.Name} es");
            return WeaponDamage.GetAtaque;
        }
    }

    public double GetDefence()
    {
        if (ArmorDamage.GetDefensa == 0)
        {
            Console.WriteLine($"La defensa del Mago {this.Name} es");
            return HealthPoints;
        }
        else
        {
            Console.WriteLine($"La defensa del Mago {this.Name} es");
            return HealthPoints += ArmorDamage.GetDefensa;
        }
    }

    public void Attack(Elfo elfo)
    {
        double attack = GetAttack();

        if (elfo.GetDefence() < attack)
        {
            elfo.HealthPoints -= attack;
        }
        else
        {
            elfo.HealthPoints -= attack;
        }
    }

    public void Attack(dwarves enano)
    {
        double attack = GetAttack();
        if (enano.GetDefence() < attack)
        {
            enano.HealthPoints -= attack;
        }
        else
        {
            enano.HealthPoints -= attack;
        }
    }

    public void Healing()
    {
        if (HealthPoints <= 75 && HealthPoints > 50)
        {
            HealthPoints += HealthPoints*0.5;
        }
        else if (HealthPoints <= 50 && HealthPoints > 25)
        {
            HealthPoints += HealthPoints * 0.75;
        }
        else if (HealthPoints <= 25)
        {
            HealthPoints = 100;
        }
    }
}