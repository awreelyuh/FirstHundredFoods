using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Baby
    {
        [Required]
        public int ID { get; set; }
                
        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(50, MinimumLength = 2), RegularExpression(@"^[A-Z]+[a-zA-Z\s]+$")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Food> Foods { get; set; }
        
        public int ParentID { get; set; }
        public Parent Parent { get; set; }
    }
}
