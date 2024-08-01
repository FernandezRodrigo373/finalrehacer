using System;
using static fernandezbarbero.rodrigo.entidades.Enumerados;

namespace fernandezbarbero.rodrigo.entidades
{
    public class ConsolaArcade:ConsolaDeJuegos, IJugar
    {
        eCantidadDeBits cantidadDeBits;
        private sbyte cantidadMaximaDeControles;
        private eFormatoJuego formatoDeJuego;


        public ConsolaArcade(eCantidadDeBits cantidadDeBits, sbyte cantidadMaximaDeControles, eFormatoJuego formatoJuego) : base(cantidadDeBits, formatoJuego, cantidadMaximaDeControles)
        {
            this.cantidadDeBits = eCantidadDeBits.bits32;
            this.cantidadMaximaDeControles = 2;
            this.formatoDeJuego = eFormatoJuego.DVD;
        }




       public eCantidadDeBits CantidadDeBits
       {
             get { return cantidadDeBits; }
            set { this.cantidadDeBits = value; }
       }

        public sbyte CantidadMaximaDeControles
        {
            get { return cantidadMaximaDeControles; }
            set { this.cantidadMaximaDeControles = value; }
        }
        public eFormatoJuego FormatoDeJuego
        {
            get { return formatoDeJuego; }
            set { this.formatoDeJuego = value; }
        }


        public override void Apagar()
        {
            Console.WriteLine("Apagando ARCADE");
        }
        

        /*public override bool Equals(ConsolaArcade ca1, ConsolaArcade ca2)
        {
            if (ca1.formatoDeJuego == ca2.formatoDeJuego && ca1.cantidadDeBits == ca2.cantidadDeBits && ca1.cantidadMaximaDeControles == ca2.cantidadMaximaDeControles)
            {
                return true;
            }
            else
            {
                return false;
            }

        }*/

        public override void FinalizarJuego()
        {
            Apagar();
        }

        public override bool IniciarJuego()
        {
            Console.WriteLine("CONSOLA ENCENDIDA");

            return true;
        }

        public override void Resetear()
        {
            Console.WriteLine("reseteando arcade");
        }

        public override string ToString()
        {
            return $"cantidad de bits: {this.cantidadDeBits}, cantidad maxima de controles {this.cantidadMaximaDeControles}, formato: {this.formatoDeJuego}";
        }

        public static bool operator ==(ConsolaArcade ca1, ConsolaArcade ca2)
        {
            if (ca1.formatoDeJuego == ca2.formatoDeJuego && ca1.cantidadDeBits == ca2.cantidadDeBits)
            {
                return true;

            }
            else
            {
                return false;
            }

        }



        public static bool operator !=(ConsolaArcade ca1, ConsolaArcade ca2)
        {
            return !(ca1 == ca2);
        }






    }
}
