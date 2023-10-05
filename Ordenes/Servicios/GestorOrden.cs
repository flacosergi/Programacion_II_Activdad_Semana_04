using Ordenes.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordenes.Entidades;

namespace Ordenes.Servicios
{
    public class GestorOrden
    {
        private IDaoOrden dao_orden;

        public GestorOrden(IDaoOrden d_orden)
        {
                dao_orden = d_orden;
        }

        public int CargarOrden(Orden_Retiro orden)
        {
            return dao_orden.IngresaOrden(orden);
        }
    }
}
