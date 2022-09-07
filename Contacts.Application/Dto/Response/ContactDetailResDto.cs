using Contacts.Domain.Enum;

namespace Contacts.Application.Dto.Response;

public class ContactDetailResDto
{
    public ContactTypeEnum ContactType { get; set; }
    public string Content { get; set; }
    public Guid ContactId { get; set; }
}