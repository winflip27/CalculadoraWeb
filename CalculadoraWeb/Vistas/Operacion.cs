using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb.Vistas
{
    public class Operacion
    {
        public int OperacionId { get; set; }
        public string TipoOperacion { get; set; }
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public double Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}