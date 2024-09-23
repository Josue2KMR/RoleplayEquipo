using System;
using Items;
using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Wizard))]
public class wizardTest
{
    [Test]
    public void Wizard_Attacks_Dwarf_ReducesHealth()
    {
        // Arrange
        var axe = new Axe { AttackValue = 30 };  // Asumimos que el hacha tiene un valor de ataque
        var armor = new Armor { DefenseValue = 20 };  // Asumimos que la armadura tiene un valor de defensa
        var wizard = new Wizard("Gandalf", 100, axe, armor);
        var dwarf = new dwarves("Thorin", 100, axe, armor);

       
        wizard.Attack(dwarf);
        
        Assert.That(dwarf.health, Is.EqualTo(100));
        Assert.That(dwarf.health, Is.EqualTo(90));
    }
}