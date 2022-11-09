using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstHundredFoods.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        //Is this the right way to generate password property???
        public string Password { get; set; }

    }
}
