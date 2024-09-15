using System;

namespace Library
{
    public class Elfo
    {
        // Atributos del elfo
        public string Nombre;
        public double PuntosDeVida = 100;
        public bool TieneArma;
        public double DañoArma;
        public bool TieneArmadura;
        public double DañoArmadura;

        // Constructor
        public Elfo(string nombre, double puntosDeVida)
        {
            Nombre = nombre;
            PuntosDeVida = puntosDeVida;
            TieneArma = false; // Por defecto, el elfo no tiene arma
            TieneArmadura = false; // Por defecto, el elfo no tiene armadura
        }

        // Métodos del elfo
        public double ObtenerAtaque()
        {
            return TieneArma ? DañoArma : 15; // Los elfos tienen un ataque base si no tienen arma
        }

        public double ObtenerDefensa()
        {
            return TieneArmadura ? DañoArmadura : 5; // Los elfos tienen una defensa base si no tienen armadura
        }

        public void Atacar(Elfo enemigo)
        {
            double ataque = ObtenerAtaque();
            if (enemigo.ObtenerDefensa() < ataque)
            {
                enemigo.PuntosDeVida -= ataque;
            }
            else
            {
                enemigo.DañoArmadura -= ataque;
            }
        }

        public void Curar()
        {
            if (PuntosDeVida <= 75 && PuntosDeVida > 50)
            {
                PuntosDeVida += PuntosDeVida * 0.5;
            }
            else if (PuntosDeVida <= 50 && PuntosDeVida > 25)
            {
                PuntosDeVida += PuntosDeVida * 0.75;
            }
            else if (PuntosDeVida <= 25)
            {
                PuntosDeVida = 100;
            }
        }

        public void EquiparArma(double daño)
        {
            TieneArma = true;
            DañoArma = daño;
        }

        public void QuitarArma()
        {
            TieneArma = false;
            DañoArma = 0;
        }

        public void EquiparArmadura(double daño)
        {
            TieneArmadura = true;
            DañoArmadura = daño;
        }

        public void QuitarArmadura()
        {
            TieneArmadura = false;
            DañoArmadura = 0;
        }
    }
}
