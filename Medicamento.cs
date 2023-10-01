using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    internal struct Medicamento
    {

        public string Codigo { get; set; }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }

        public double MontoInvertido { get; set; }

        public Medicamento(string v_codigo, string v_nombre, 
            int v_cantidad, double v_precio_unitario)
        {
            Codigo = v_codigo;
            Nombre = v_nombre;
            Cantidad = v_cantidad;
            PrecioUnitario = v_precio_unitario;
            MontoInvertido = Cantidad * PrecioUnitario;
        }
    }
}
