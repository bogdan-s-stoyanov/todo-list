using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200, ErrorMessage = "Description cant be over 200 characters")]
        public string Description { get; set; } = string.Empty; 

        public bool IsCompleted { get; set; }

        public DateTime? DueDate { get; set; }

        public string UserId { get; set; } = string.Empty;
        public IdentityUser User { get; set; }
    }
}
