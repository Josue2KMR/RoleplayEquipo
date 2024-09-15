using System;

namespace Library;

public class wizard
{
    // Atributos del mago
    public string Name;
    public double hp = 100;
    public bool weapon;
    public double weaponDamage;
    public bool armor;
    public double armorDamage;
    public Dictionary<string, double> SpellBook;
    
    // Constructor
    public wizard(string name, double hp)
    {
        Name = name;
        this.hp = hp;
        SpellBook = new Dictionary<string, double>()
        {
            {"Ice", 100}, {"Fire", 150}, {"SuperNova", 350}, {"Eclipse", 250}, {"Berserk", 9999}
        };
    }
    
    // Métodos del mago
    public double SelectSpell(string Spell)
    {
        if (SpellBook.ContainsKey(Spell))
        {
            weaponDamage = SpellBook[Spell];
            return weaponDamage;
        }
        else
        {
            Console.WriteLine("No spell available");
            return 0;
        }
    }
    public double GetAtaque()
    {
        return weapon ? weaponDamage : 10;
    }

    public double GetDefence()
    {
        return armor ? armorDamage : 0;
    }

    public Dictionary<string, double> GetSpellBook()
    {
        return SpellBook;
    }

    public void Attack(elves elfo)
    {
        double attack = GetAtaque();

        if (elfo.GetDefence() < attack)
        {
            elfo.hp -= attack;
        }
        else
        {
            elfo.armorDamage -= attack;
        }
    }

    public void Attack(dwarves enano)
    {
        double attack = GetAtaque();
        if (enano.GetDefence() < attack)
        {
            enano.hp -= attack;
        }
        else
        {
            enano.armorDamage -= attack;
        }
    }

    public void healing()
    {
        if (hp <= 75 && hp > 50)
        {
            hp += hp*0.5;
        }
        else if (hp <= 50 && hp > 25)
        {
            hp += hp * 0.75;
        }
        else if (hp <= 25)
        {
            hp = 100;
        }
    }
}