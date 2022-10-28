using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Vehicles.Entities;

namespace Vehicles.DTOs
{
    public class HistoryCreationDTO
    {
        public string description { get; set; }
        public int vehicleId { get; set; }

        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime fecha { get; set; }

        [Display(Name = "Vehicle")]
        [JsonIgnore]
        public Vehicle vehicle { get; set; }

        [Display(Name = "Details")]
        [JsonIgnore]
        public ICollection<Detail> details { get; set; }
    }
}
