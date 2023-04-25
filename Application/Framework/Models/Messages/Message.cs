using System.ComponentModel.DataAnnotations.Schema;

namespace Otr.Dccfe.Application.Models.Chat
{
    public class Message
    {
        [Column(TypeName = "varchar(128)")]
        public string ToUserId { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string FromUserId { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string MessageText { get; set; }
    }
}