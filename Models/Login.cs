using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required,MinLength(3)]
        public String Username  { get; set; }
        [Required]
        [Display(Name = "Mot de passe")]
        [MinLength(5),DataType(DataType.Password)]
        public String Password { get; set; }

        /*[Display(Name = "Confirmer mot de passe")]
        [Compare("Password"),DataType(DataType.Password)]
        public String ConfirmPassword { get; set; }
        [EmailAddress,Required]
        public string Email { get; set; }*/
    }
}
