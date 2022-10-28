using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using Vehicles.Entities;

namespace Vehicles.DTOs
{
    public class DetailCreationDTO
    {
        public int HistoryId { get; set; }

        public int ProcedureId { get; set; }

        [Display(Name = "History")]
        [JsonIgnore]
        public History history { get; set; }

        [Display(Name = "Procedure")]
        [JsonIgnore]
        public Procedure procedure { get; set; }
    }
}
