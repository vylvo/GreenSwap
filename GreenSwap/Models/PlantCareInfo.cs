using System.ComponentModel.DataAnnotations;

namespace GreenSwap.Models
{
    public class PlantCareInfo
    {
        [Key]
        public int InfoID { get; set; }

        [Required]
        public string PlantTypeName { get; set; }

        [Required]
        public string WateringFrequency { get; set; }

        [Required]
        public string LightRequirements { get; set; }

        public string SoilPreferences { get; set; }

        [Required]
        public int DifficultyLevel { get; set; }

        public string GrowthHabits { get; set; }

        public string CommonIssues { get; set; }
    }
}