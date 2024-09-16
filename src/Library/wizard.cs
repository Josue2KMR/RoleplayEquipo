using System;

namespace Library;

public class wizard
{
    // Atributos del mago
    public string Name;
    public double HealthPoints = 100;
    public bool Weapon;
    public double WeaponDamage;
    public bool Armor;
    public double ArmorDamage;
    public LibroDeHechizos SpellBook;
    
    // Constructor
    public wizard(string name, double hp,LibroDeHechizos spellBook)
    {
        Name = name;
        HealthPoints = hp;
        SpellBook = spellBook;

    }
    
    // Métodos del mago
    public double SelectSpell(string Spell)
    {
        if (SpellBook.GetListaHechizos.Contains(Spell))
        {
            WeaponDamage = SpellBook[Spell];
            return WeaponDamage;
        }
        else
        {
            Console.WriteLine("No spell available");
            return 0;
        }
    }
    public double GetAtaque()
    {
        return Weapon ? WeaponDamage : 10;
    }

    public double GetDefence()
    {
        return Armor ? ArmorDamage : 0;
    }

    public Dictionary<string, double> GetSpellBook()
    {
        return SpellBook;
    }

    public void Attack(Elves elfo)
    {
        double attack = GetAtaque();

        if (elfo.GetDefence() < attack)
        {
            elfo.HealthPoints -= attack;
        }
        else
        {
            elfo.ArmorDamage -= attack;
        }
    }

    public void Attack(dwarves enano)
    {
        double attack = GetAtaque();
        if (enano.GetDefence() < attack)
        {
            enano.HealthPoints -= attack;
        }
        else
        {
            enano.ArmorDamage -= attack;
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