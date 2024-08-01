using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static fernandezbarbero.rodrigo.entidades.Enumerados;

namespace fernandezbarbero.rodrigo.entidades
{
    public class ConsolaPortatil: ConsolaDeJuegos, IJugar
    {
        private sbyte autonomiaActual;

        eCantidadDeBits cantidadDeBits;
        private sbyte cantidadMaximaDeControles;
        private eFormatoJuego formatoDeJuego;


        public ConsolaPortatil(eCantidadDeBits cantidadDeBits, sbyte cantidadMaximaDeControles, eFormatoJuego formatoJuego, sbyte autonomiaActual) : base(cantidadDeBits, formatoJuego, cantidadMaximaDeControles)
        {
            this.cantidadDeBits = eCantidadDeBits.bits32;
            this.cantidadMaximaDeControles = 2;
            this.formatoDeJuego = eFormatoJuego.DVD;
            this.autonomiaActual = autonomiaActual;
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

        public sbyte AutonomiaActual
        {
            get { return autonomiaActual; }
            set { this.autonomiaActual = value; }
        }


        public override void Apagar()
        {
            Console.WriteLine("apagando CONSOLA PORTATIL");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void FinalizarJuego()
        {
            this.AutonomiaActual -= 5;

            if(autonomiaActual < 3)
            {
                Apagar();
            }
        }

        public override bool IniciarJuego()
        {
            if(autonomiaActual > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Resetear()
        {
            Console.WriteLine("reseteando CONSOLA PORTATIL");
        }

        public override string ToString()
        {
            return $"autonomia actual: {this.autonomiaActual}, cantidad de bits:{this.cantidadDeBits}, cantidad maxima de controles {this.cantidadMaximaDeControles}, formato: {this.formatoDeJuego}";
        }

        public static bool operator ==(ConsolaPortatil cp1, ConsolaPortatil cp2)
        {
            if(cp1.formatoDeJuego == cp2.formatoDeJuego && cp1.cantidadDeBits == cp2.cantidadDeBits)
            {
                return (cp1.Equals(cp2));

            }
            else
            {
                return false;
            }
            
        }

       

        public static bool operator !=(ConsolaPortatil cp1, ConsolaPortatil cp2)
        {
            return !(cp1 == cp2);
        }






    }
}
