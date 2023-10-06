using ParcialApp.Acceso_a_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcialApp.Dominio;


namespace ParcialApp.Servicios
{
    public class GestorMaterial
    {
        private IDaoMaterial Dao = new DaoMaterial();

        public List<Material> CargarMateriales()
        {
            return Dao.GetMateriales();
        }

    }
}
