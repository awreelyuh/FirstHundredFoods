using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public enum FoodType
    {
        vegetable, fruit, meat, nut, grain, dairy, seafood, herbSpice, legumeBean
    }
    public class Food
    {
        [Required]
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string Name { get; set; }
        public bool ContainsAllergen { get; set; }
        public FoodType FoodType { get; set; }
        public bool RequiresCooking { get; set; }

    }
}
