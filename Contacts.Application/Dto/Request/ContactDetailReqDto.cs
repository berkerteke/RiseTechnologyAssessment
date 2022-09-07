using System.ComponentModel.DataAnnotations;
using Contacts.Domain.Entity;
using Contacts.Domain.Enum;

namespace Contacts.Application.Dto.Request;

public class ContactDetailReqDto
{
    [Required]
    public ContactTypeEnum ContactType { get; set; }
    [Required]

    public string Content { get; set; }
    [Required]
    public Guid ContactId { get; set; }
}