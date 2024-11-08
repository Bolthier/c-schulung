using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WortmannNoteWebApi.Models
{
    [Table("Note")]
    public class NoteModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Header { get; set; }
        public string? Content { get; set; }
        public DateTime Posted { get; set; }
        [Required]
        public UserModel User { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
