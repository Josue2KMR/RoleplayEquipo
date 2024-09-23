using Items;
using Library;
using Library.Interfaces;

IItemAttackValue espada = new Sword();
IItemDefenseValue casco = new Helmet();
IPersonaje gimli = new dwarves("gimli", 100, espada, casco);
IPersonaje dobby = new Elfo("dobby", 100, espada, casco);
gimli.GetDefence();

