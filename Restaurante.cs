using System.ComponentModel.DataAnnotations;

namespace EmpresaUTN.Modelos
{
    public class Restaurante
    {
        [Key]
        public int CodigoRestaurante { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Especialidad { get; set; }

        // Relación con la clase secundaria Platos
        public List<Plato>? Platos { get; set; } 


    }
}