using Items;
using Library;
using Library.Interfaces;

namespace RoleplayGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            IItemAttackValue espada = new Sword();
            IItemDefenseValue casco = new Helmet();
            IPersonaje gimli = new dwarves("gimli", 100, espada, casco);
            IPersonaje franui = new Elfo("franui", 100, espada, casco);
            gimli.GetDefence();
        }
    }
}


