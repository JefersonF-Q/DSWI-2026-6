using System.ComponentModel.DataAnnotations;

namespace DSWI_sesion02.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal Precio { get; set; }

        [Required (ErrorMessage = "La cantidad es obligatoria")]
        public int Cantidad { get; set; }
        public int Estado { get; set; }

    }
}
