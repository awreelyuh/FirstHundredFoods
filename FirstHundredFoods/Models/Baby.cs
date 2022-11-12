using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Baby
    {
        [Required]
        public int ID { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Food> Foods { get; set; }
    }
}
