namespace Projet.Models
{
    public class User
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [StringLength(30)]
        public String Nom { get; set; }
        [Required]
        public String Email { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        public uint mobile { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [StringLength(30)]
        public String ville { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [Display(Name = "Age")]
        public uint age { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [DataType(DataType.Date)]
        public DateTime anniv { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [StringLength(30)]
        [Display(Name = "Nom d'utilisateur")]
        public String nomUt { get; set; }
        [Required(ErrorMessage = "Ce champ ne doit pas être vide")]
        [Display(Name = "Mot de passe")]
        [MinLength(8)]
        public String password { get; set; }
    }
}
