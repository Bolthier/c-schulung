using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De.Wortmann.Chat.CodeFirstDb.Models
{
    [Table("chat")]
    public class ChatModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Header { get; set; }
        public string Sender { get; set; }
        public string DateCreate { get; set; }
    }
}
