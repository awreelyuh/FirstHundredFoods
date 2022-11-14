using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Baby
    {
        [Required]
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string FirstName { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Food> Foods { get; set; }
        public ICollection<Allergen> Allergens { get; set; }
    }
}
