using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Vehicles.Entities
{
    public class Brand
    {
        // Brand whit relationship
        public int Id { get; set; }

        [Display(Name = "Brand name")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string nombre { get; set; }

        [JsonIgnore]
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
