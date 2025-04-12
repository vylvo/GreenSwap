using System.ComponentModel.DataAnnotations;

namespace GreenSwap.Models
{
    public class PlantCareInfo
    {
        [Key]
        public int InfoID { get; set; }

        [Required]
        public string PlantTypeName { get; set; } = string.Empty;

        [Required]
        public string WateringFrequency { get; set; } = string.Empty;

        [Required]
        public string LightRequirements { get; set; } = string.Empty;

        public string? SoilPreferences { get; set; }

        [Required]
        public int DifficultyLevel { get; set; }

        public string? GrowthHabits { get; set; }

        public string? CommonIssues { get; set; }
    }
}