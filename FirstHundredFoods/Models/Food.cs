using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public enum FoodType
    {
        Vegetable,
        Fruit,
        Meat,
        Nut,
        Grain,
        Dairy,
        Seafood,
        [Display(Name = "Herb or Spice")] 
        HerbSpice,
        Legume,
        Other
    }
    public class Food
    {
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string Name { get; set; }
        
        [Display(Name = "Contains Allergen")]
        public bool ContainsAllergen { get; set; }

        [Display(Name = "Food Type")]
        public FoodType FoodType { get; set; }

    }
}
