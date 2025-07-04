using System.ComponentModel.DataAnnotations;

namespace Projet.Models
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public int CommentId { get; set; }
        [ForeignKey("CommentId")]
        public virtual Comment Comment { get; set; }

    }
}
