using Application.Contracts.Messages;
using Application.Framework.Models.Chat;

namespace Application.Framework.Responses.Identity
{
    public class MessengerResponse
    {
        public string Id { get; set; } 
        public string UserName { get; set; } = string.Empty;
        public string ProfilePictureDataUrl { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public bool IsOnline { get; set; }
        public virtual ICollection<MessagesHistory<IMessenger>> MessagesHistoriesFromUsers { get; set; } 
        public virtual ICollection<MessagesHistory<IMessenger>> MessagesHistoriesToUsers { get; set; } 
    }
}