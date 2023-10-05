using Ordenes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Datos
{
    public interface IDaoOrden
    {
        int IngresaOrden(Orden_Retiro orden);
    }
}
