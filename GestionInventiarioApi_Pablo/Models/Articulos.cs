using System.ComponentModel.DataAnnotations;

namespace GestionInventiarioApi_Pablo.Models
{
    public class Articulos
    {
        [Key]
        public int articuloId { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public double existencia { get; set; }
    }
}
