using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Contracts.Messages;

public interface IMessenger
{
    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string LastName { get; set; }

    [Column(TypeName = "text")]
    public string ProfilePictureDataUrl { get; set; }
}