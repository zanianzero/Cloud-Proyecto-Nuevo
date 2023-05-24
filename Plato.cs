using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaUTN.Modelos
{
    public class Plato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }



        // Relación con la clase principal Restaurante
        public int RestauranteCodigoRestaurante { get; set; } // Clave foránea
        public Restaurante? Restaurante { get; set; }

        // Relación con la tercera clase Ingredientes
        public List<Ingrediente>? Ingredientes { get; set; }





    }
}
