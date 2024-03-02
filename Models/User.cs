using System.ComponentModel.DataAnnotations;

namespace Game_review_project.Models
{
    public class User 
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
