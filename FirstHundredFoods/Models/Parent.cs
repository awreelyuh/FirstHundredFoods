using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class Parent
    {
        public int ID { get; set; }
        
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Child(ren)")]
        public List<Baby> Babies { get; set; }
    }
}
