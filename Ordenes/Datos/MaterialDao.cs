using Ordenes.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Datos
{
    public class MaterialDao : IDaoMaterial
    {
        public List<Material> ObtenerTodo()
        {
            List<Material> lst = new List<Material> ();
            DataTable Tabla = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_MATERIALES");
          
            foreach (DataRow fila in Tabla.Rows)
            {
                Material aux = new();
                aux.codigo = (int)fila["codigo"];
                aux.nombre = (string) fila["nombre"];
                aux.stock = (decimal)fila["stock"];
                lst.Add(aux);
            }

            return lst;
        }
    }
}
