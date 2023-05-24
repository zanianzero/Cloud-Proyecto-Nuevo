using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaUTN.Modelos
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        // Relación con la clase secundaria Plato
        public  int PlatoID { get; set; } // Clave foránea
        public Plato? Plato { get; set; }
    }
}
