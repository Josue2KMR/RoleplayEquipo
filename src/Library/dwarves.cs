using System;
namespace Library;

public class dwarves
{
    //Atributos del enanooo
    public string Name;
    public double HealthPoints = 150;
    public bool Weapon;
    public double WeaponDamage;
    public bool Armor;
    public double ArmorDamage;
    public Dictionary<string, double> Weapons;

    //Constructor
    public dwarves(string name, double hp)
    {
        Name = name;
        HealthPoints = hp;
        Weapons = new Dictionary<string, double>()
        {
            { "Punch", 20 }, { "Axe", 70 }, { "Hammer", 90 }, { "Gun", 120 }
        };
    }

    //Metodos
    public double SelectWeapon(string weapon)
    {
        if (Weapons.ContainsKey(weapon))
        {
            WeaponDamage = Weapons[weapon];
            Weapon = true;
            return WeaponDamage;
        }
        else
        {
            Console.WriteLine("No weapon available");
            return 0;
        }
    }

    public double GetAttack()
    {
        return Weapon ? WeaponDamage : 15;  
    }

    public double GetDefence()
    {
        return Armor ? ArmorDamage : 10;
    }


    public void EquipArmor(string armor, double defense)
    {
        Armor = true;
        ArmorDamage = defense;
    }

    public void Attack(wizard wizard)
    {
        double attack = GetAttack();
        if (wizard.GetDefence() < attack)
        {
            wizard.HealthPoints -= attack;
        }
        else
        {
            wizard.ArmorDamage -= attack;
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
            elfo.ArmorDefense -= attack;
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