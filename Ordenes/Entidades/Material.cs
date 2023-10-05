using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes.Entidades
{
    public class Material
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal stock { get; set; }


        public Material()
        {
            codigo = 0;
            nombre = string.Empty;
            stock = 0;
        }

        public Material(int cod, string nom, decimal stk)
        {
            codigo = cod;
            nombre = nom;
            stock = stk;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
