using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordenes.Entidades;

namespace Ordenes.Datos
{
    public class OrdenDao: IDaoOrden
    {
        public int IngresaOrden(Orden_Retiro orden)
        {
            int numero_orden = 0;
            List<SqlParameter> lista_param_ordenes = new();
            lista_param_ordenes.Add(new SqlParameter("@responsable", orden.responsable));
            SqlParameter salida = new();
            salida.Direction = System.Data.ParameterDirection.Output;
            salida.ParameterName = "@nro";
            salida.SqlDbType = System.Data.SqlDbType.Int;
            DBHelper.ObtenerInstancia().AbreConexionConTransaccion();
            numero_orden =  DBHelper.ObtenerInstancia().CargaRegistro("SP_INSERTAR_ORDEN", lista_param_ordenes, salida);
            foreach (Detalle_Orden det in orden.lista_detalle)
            {
                List<SqlParameter> lista_param_detalle = new();
                lista_param_detalle.Add(new SqlParameter("@nro_orden", numero_orden));
                lista_param_detalle.Add(new SqlParameter("@detalle", det.detalle_nro));
                lista_param_detalle.Add(new SqlParameter("@codigo", det.material.codigo));
                lista_param_detalle.Add(new SqlParameter("@cantidad", det.cantidad));
                DBHelper.ObtenerInstancia().CargaRegistro("SP_INSERTAR_DETALLES", lista_param_detalle, null);
            }
            DBHelper.ObtenerInstancia().CierraConexionConTransaccion();
            return numero_orden;
        }
    }
}
