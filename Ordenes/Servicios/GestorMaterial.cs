using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ordenes.Datos;
using Ordenes.Entidades;

namespace Ordenes.Servicios
{
    public class GestorMaterial
    {
        private IDaoMaterial daomat;

        public GestorMaterial(IDaoMaterial dao_mat)
        {
            daomat = dao_mat;
        }

        public List<Material> ObtenerMateriales()
        {
            return daomat.ObtenerTodo();
        }


    }
}
