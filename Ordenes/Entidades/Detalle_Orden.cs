using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Entidades
{
    public class Detalle_Orden
    {
        public int nro_orden { get; set; }
        public int detalle_nro { get; set; }
        public Material material{ get; set; }
        public int cantidad { get; set; }

        public Detalle_Orden()
        {
            nro_orden = 0;
            detalle_nro = 0;
            material = new Material();
            cantidad = 0;
        }

        public Detalle_Orden(int num_ord, int det_nro, int cod, int cant, Material mat)
        {
            nro_orden = num_ord;
            detalle_nro = detalle_nro;
            material = mat;
            cantidad = cant;
        }

 
    }
}
