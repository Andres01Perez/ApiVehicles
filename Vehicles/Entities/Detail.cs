using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Vehicles.Entities
{
    public class Detail
    {
        // Detail whit relationship
        public int Id { get; set; }
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
