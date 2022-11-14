using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Food
    {
        [Required]
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string Name { get; set; }
        public bool ContainsAllergen { get; set; }
        public ICollection<Allergen> Allergens { get; set; }
        public string Type { get; set; } //Vegetable, fruit, meat, nut, grain, dairy, seafood, herb/spice, legume/bean
        public bool RequiresCooking { get; set; }

    }
}
