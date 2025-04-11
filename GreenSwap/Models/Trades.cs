using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSwap.Models
{
    public class Trade
    {
        [Key]
        public int TradeID { get; set; }

        [Required]
        public int RequestorID { get; set; }

        [Required]
        public int ProviderID { get; set; }

        [Required]
        public int PlantID { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";

        public DateTime? CompletionDate { get; set; }

        public string TradeNotes { get; set; }

        // Navigation properties
        [ForeignKey("RequestorID")]
        public virtual User Requestor { get; set; }

        [ForeignKey("ProviderID")]
        public virtual User Provider { get; set; }

        [ForeignKey("PlantID")]
        public virtual Plant Plant { get; set; }
    }
}