using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Note
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

    }
}
