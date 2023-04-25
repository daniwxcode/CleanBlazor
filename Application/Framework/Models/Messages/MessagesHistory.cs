using Application.Contracts.Messages;

using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Framework.Models.Chat
{
    public partial class MessagesHistory<TUser> : IMessages<TUser> where TUser : IMessenger
    {
        public long Id { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string FromUserId { get; set; }
        [Column(TypeName = "varchar(128)")]
        public string ToUserId { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual TUser FromUser { get; set; }
        public virtual TUser ToUser { get; set; }
    }
}