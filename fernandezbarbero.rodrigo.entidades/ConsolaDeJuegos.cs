using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static fernandezbarbero.rodrigo.entidades.Enumerados;

namespace fernandezbarbero.rodrigo.entidades
{
    public abstract class ConsolaDeJuegos: IJugar
    {
        eCantidadDeBits cantidadDeBits;
        Enumerados.eFormatoJuego formatoDeJuego;
        private sbyte cantidadMaximaDeControles;
        private string nombre;

        public ConsolaDeJuegos(eCantidadDeBits cantidadDeBits, eFormatoJuego formatoDeJuego, sbyte cantidadMaximaDeControles)
        {
            this.cantidadDeBits = cantidadDeBits;
            this.formatoDeJuego = formatoDeJuego;
            this.cantidadMaximaDeControles = cantidadMaximaDeControles;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public abstract void Apagar();
   

 

        public abstract void FinalizarJuego();


        public abstract bool IniciarJuego();


        public abstract void Resetear();

        public static bool operator +(ConsolaDeJuegos consola, List<ConsolaDeJuegos> consolas)
        {
            TiendaVideoJuegos tienda = new TiendaVideoJuegos();

            if (consolas.Count < tienda.CantidadMaximaDeConsolasEnStock)
            {
                foreach (ConsolaDeJuegos item in consolas)
                {
                    if (tienda.Nombre != item.Nombre)
                    {
                        consolas.Add(consola);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("El nombre ya existe");
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("no hay espacio");
                return false;
            }

            return false;
        }






    }
}
