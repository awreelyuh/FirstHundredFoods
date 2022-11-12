using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Food
    {
        [Required]
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string Name { get; set; }
        public bool CommonAllergen { get; set; }
        public string Type { get; set; }
        public bool RequiresCooking { get; set; }

    }
}
