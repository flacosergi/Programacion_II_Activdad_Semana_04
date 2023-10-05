using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Entidades
{
    public class Orden_Retiro
    {
        public int nro { get; set; }
        public DateTime fecha { get; set; }
        public string responsable { get; set; }
        public List<Detalle_Orden> lista_detalle { get; set; }

        public Orden_Retiro()
        {
            nro = 0;
            fecha = DateTime.Now;
            responsable = string.Empty;
            lista_detalle= new List<Detalle_Orden>();
        }

        public Orden_Retiro(int num, DateTime fech, string resp , List<Detalle_Orden> lista )
        {
            nro = num;
            fecha = fech;
            responsable = resp;
            lista_detalle = lista;
        }

        public void AgregarDetalle(Detalle_Orden det)
        {
            lista_detalle.Add(det);
        }

        public void QuitarDetalle(int nrodet)
        {
            lista_detalle.RemoveAt(nrodet);
        }

        public override string ToString()
        {
            return nro.ToString();
        }
    }

    
}
