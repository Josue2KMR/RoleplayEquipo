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
        if (WeaponDamage == null)
        {
            return 10;
        }
    }

    public double GetDefence()
    {
        if (ArmorDamage.GetDefensa == null)
        {
            return HealthPoints;
        }
        else
        {
            return HealthPoints += ArmorDamage.GetDefensa;
        }
    }

    public void Attack(Elfo elfo)
    {
        double attack = GetAttack();

        if (elfo.ObtenerDefensa() < attack)
        {
            elfo.PuntosDeVida -= attack;
        }
        else
        {
            elfo.DañoArmadura -= attack;
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