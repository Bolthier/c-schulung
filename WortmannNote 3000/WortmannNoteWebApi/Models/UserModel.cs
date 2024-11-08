using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WortmannNoteWebApi.Models
{
    [Table("USER")]
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        public IEnumerable<NoteModel> Notes { get; set; }
    }
}
