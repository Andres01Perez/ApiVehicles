using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Vehicles.Entities;

namespace Vehicles.DTOs
{
    public class ProcedureDTO
    {
        public int Id { get; set; }

        [Display(Name = "Procedure name")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string nombre { get; set; }

        [Display(Name = "Procedure description")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string description { get; set; }

        [JsonIgnore]
        public ICollection<Detail> details { get; set; }
    }
}
