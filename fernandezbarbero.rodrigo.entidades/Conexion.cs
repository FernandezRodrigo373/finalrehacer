using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fernandezbarbero.rodrigo.entidades
{
    public static class Conexion
    {
        public static bool conectar()
        {
            SqlConnection conexionABase = new SqlConnection("Persist Security Info=False;User ID=sa;Initial Catalog=DBConsola;Data Source=LAB6PC4");

            SqlCommand comando = new SqlCommand();

            conexionABase.Open();

            return true;
        }
       

    }
}
