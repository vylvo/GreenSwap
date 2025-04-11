using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenSwap.Models
{
    public class Plant
    {
        [Key]
        public int PlantID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public string PlantName { get; set; }

        [Required]
        public string PlantType { get; set; }

        public string Description { get; set; }

        public string AgeOrStage { get; set; }

        [Required]
        public DateTime DateListed { get; set; }

        [Required]
        public string Status { get; set; } = "Available";

        // Navigation properties
        [ForeignKey("UserID")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Trade> Trades { get; set; }

        public Plant()
        {
            Trades = new HashSet<Trade>();
        }
    }
}