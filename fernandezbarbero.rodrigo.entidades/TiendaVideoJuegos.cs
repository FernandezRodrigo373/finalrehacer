using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fernandezbarbero.rodrigo.entidades
{
    public class TiendaVideoJuegos
    {
        private sbyte cantidadMaximaDeConsolasEnStock;
        private List<ConsolaDeJuegos> consolas;
        private string nombre;
        ConsolaDeJuegos consolaDeJuegos;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public List<ConsolaDeJuegos> Consolas
        { 
           get { return consolas; }
           set { consolas = value; }
           
        }

        public sbyte CantidadMaximaDeConsolasEnStock
        {
            get { return cantidadMaximaDeConsolasEnStock; }
            set { cantidadMaximaDeConsolasEnStock = value; }
        }

        public override string ToString()
        {
            return $"nombre {this.nombre}, consolas: {this.consolas}, cantidad maxima de consolas en stock: {this.cantidadMaximaDeConsolasEnStock}";
        }

        

    }
}
