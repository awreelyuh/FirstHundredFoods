using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Baby
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required, DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Food> Foods { get; set; }
    }
}
